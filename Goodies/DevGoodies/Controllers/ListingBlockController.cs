namespace DevGoodies.Controllers
{
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.Filters;
    using EPiServer.Web.Mvc;

    using DevGoodies.ViewModels;
    using DevGoodies.Models.Blocks;

    using System.Linq;
    using System.Web.Mvc;
    using System.Collections.Generic;

    public class ListingBlockController : BlockController<ListingBlock>
    {
        //---------------- FIELDS -----------------
        public readonly IContentLoader loader;

        //------------- CONSTRUCTORS --------------
        public ListingBlockController(IContentLoader loader)
        {
            this.loader = loader;
        }

        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public override ActionResult Index(ListingBlock currentBlock)
        {
            var viewModel = new ListingBlockViewModel
            {
                Heading = currentBlock.Heading,
            };

            if (currentBlock.Children != null)
            {
                IEnumerable<PageData> children = loader.GetChildren<PageData>(currentBlock.Children);

                // FILTER:
                // 1. That are not published
                // 2. That the visitor does not have READ access to
                // 3. That do not have a page template
                IEnumerable<IContent> filteredChildren = FilterForVisitor.Filter(children);

                // 4. That do not have "Display in navigation" selected
                IEnumerable<PageData> pages = filteredChildren.Cast<PageData>().Where(page => page.VisibleInMenu);

                viewModel.Pages = pages;
            }

            return PartialView(viewModel);
        }
    }
}
