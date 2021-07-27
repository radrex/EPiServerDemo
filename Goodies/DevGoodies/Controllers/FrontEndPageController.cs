namespace DevGoodies.Controllers
{
    using EPiServer;

    using DevGoodies.Models.Pages;

    using System.Web.Mvc;

    public class FrontEndPageController : BasePageController<FrontEndPage>
    {
        //------------- CONSTRUCTORS --------------
        public FrontEndPageController(IContentLoader loader) : base(loader)
        {

        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Index(FrontEndPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}