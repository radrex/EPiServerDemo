namespace DevGoodies.Controllers
{
    using EPiServer;
    
    using DevGoodies.Models.Pages;

    using System.Web.Mvc;

    public class GeneralPageController : BasePageController<GeneralPage>
    {
        //------------- CONSTRUCTORS --------------
        public GeneralPageController(IContentLoader loader) : base(loader)
        {

        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Index(GeneralPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}