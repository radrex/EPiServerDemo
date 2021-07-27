namespace DevGoodies.Controllers
{
    using EPiServer;

    using DevGoodies.Models.Pages;
    
    using System.Web.Mvc;

    public class BackEndPageController : BasePageController<BackEndPage>
    {
        //------------- CONSTRUCTORS --------------
        public BackEndPageController(IContentLoader loader) : base(loader)
        {

        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public ActionResult Index(BackEndPage currentPage)
        {
            return this.View(this.CreatePageViewModel(currentPage));
        }
    }
}