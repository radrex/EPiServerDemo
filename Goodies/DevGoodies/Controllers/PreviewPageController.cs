namespace DevGoodies.Controllers
{
    using EPiServer;
    using EPiServer.Web;
    using EPiServer.Core;
    using EPiServer.Web.Mvc;
    using EPiServer.Framework.Web;
    using EPiServer.ServiceLocation;
    using EPiServer.Framework.DataAnnotations;

    using DevGoodies.Models.Pages;
    using DevGoodies.ViewModels;

    using System.Web.Mvc;

    [TemplateDescriptor(Inherited = true, TemplateTypeCategory = TemplateTypeCategories.MvcController, Tags = new[] { RenderingTags.Preview }, AvailableWithoutTag = false)]
    public class PreviewPageController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Index(IContent currentContent)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<BasePage>(ContentReference.StartPage);
            var viewModel = new PreviewPageViewModel(startPage, currentContent);

            return View(viewModel);
        }
    }
}