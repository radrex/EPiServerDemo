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

    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Security;

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

            viewModel.MenuPages = FilterForVisitor.Filter(loader.GetChildren<BasePage>(ContentReference.StartPage))
                                                  .Cast<BasePage>()
                                                  .Where(page => page.VisibleInMenu);

            viewModel.Section = currentPage.ContentLink.GetSection();
            return viewModel;
        }
    }
}