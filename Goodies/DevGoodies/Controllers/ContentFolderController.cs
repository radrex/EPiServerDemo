namespace DevGoodies.Controllers
{
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.Web.Mvc;

    using DevGoodies.ViewModels;

    using System.Linq;
    using System.Web.Mvc;

    public class ContentFolderController : PartialContentController<ContentFolder>
    {
        //---------------- FIELDS -----------------
        private readonly IContentLoader loader;

        //------------- CONSTRUCTORS --------------
        public ContentFolderController(IContentLoader loader)
        {
            this.loader = loader;
        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public override ActionResult Index(ContentFolder currentContent) // PARAMETER NAME SENSITIVE... currentPage/currentBlock/currentContent
        {
            var viewModel = new ContentFolderViewModel
            {
                ContentFolder = currentContent,
                ItemsCount = loader.GetChildren<IContent>(currentContent.ContentLink).Count(),
            };

            return PartialView(viewModel);
        }
    }
}
