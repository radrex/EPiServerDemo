namespace DevGoodies.Controllers
{
    using EPiServer;

    using DevGoodies.Models.Pages;

    using System.Web.Mvc;

    public class StartPageController : BasePageController<StartPage>
    {
        //------------- CONSTRUCTORS --------------
        public StartPageController(IContentLoader loader) : base(loader)
        {

        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Index(StartPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}