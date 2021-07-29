namespace DevGoodies.Controllers
{
    using EPiServer.Web.Mvc;

    using DevGoodies.ViewModels;
    using DevGoodies.Models.Pages;

    using System.Web.Mvc;

    public class GeneralPagePartialController : PartialContentController<GeneralPage>
    {
        public override ActionResult Index(GeneralPage currentPage)
        {
            return PartialView(PageViewModel.Create(currentPage));
        }
    }
}