namespace DevGoodies.Controllers
{
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.Filters;
    using EPiServer.Web.Mvc;

    using DevGoodies.Interfaces;
    using DevGoodies.ViewModels;
    using DevGoodies.Models.Pages;
    using DevGoodies.Business.ExtensionMethods;

    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Security;
    using System.Collections.Generic;

    public abstract class BasePageController<T> : PageController<T> where T : BasePage
    {
        //---------------- FIELDS -----------------
        protected readonly IContentLoader loader;

        //------------- CONSTRUCTORS --------------
        public BasePageController(IContentLoader loader)
        {
            this.loader = loader;
        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return this.RedirectToAction("Index");
        }

        //---------------- METHODS ----------------
        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(TPage currentPage) where TPage : BasePage
        {
            var viewModel = PageViewModel.Create(currentPage);
            viewModel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);

            IEnumerable<BasePage> children = FilterForVisitor.Filter(loader.GetChildren<BasePage>(currentPage.ContentLink))
                                                             .Cast<BasePage>()
                                                             .Where(page => page.VisibleInMenu);
            viewModel.Children = children;
            viewModel.Section = currentPage.ContentLink.GetSection();

            this.FillPagesMap(viewModel.PageURLs, viewModel.StartPage);
            return viewModel;
        }

        protected void FillPagesMap(Dictionary<string, List<string>> pagesMap, BasePage page)
        {
            if (!pagesMap.ContainsKey(page.Name))
            {
                pagesMap[page.Name] = new List<string>();
                IEnumerable<BasePage> children = FilterForVisitor.Filter(loader.GetChildren<BasePage>(page.ContentLink))
                                                 .Cast<BasePage>()
                                                 .Where(x => x.VisibleInMenu);

                foreach (BasePage child in children)
                {
                    pagesMap[page.Name].Add(child.ContentLink.ExternalURLFromReference()); // TODO: Dictionary key name can duplicate on pages with same name
                    this.FillPagesMap(pagesMap, child);
                }
            }
        }
    }
}