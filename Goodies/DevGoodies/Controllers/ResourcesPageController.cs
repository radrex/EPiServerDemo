namespace DevGoodies.Controllers
{
    using EPiServer;

    using DevGoodies.Models.Pages;

    using System.Web.Mvc;

    public class ResourcesPageController : BasePageController<ResourcesPage>
    {
        //------------- CONSTRUCTORS --------------
        public ResourcesPageController(IContentLoader loader) : base(loader)
        {

        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Index(ResourcesPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}