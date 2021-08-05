namespace DevGoodies.Controllers
{
    using EPiServer.Web.Mvc;

    using DevGoodies.ViewModels;
    using DevGoodies.Models.Blocks;

    using System.Web.Mvc;

    public class NestedBlockController : BlockController<NestedBlock>
    {
        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public override ActionResult Index(NestedBlock currentBlock)
        {
            var viewModel = new NestedBlockViewModel
            {
                CurrentBlock = currentBlock,
            };

            return PartialView(viewModel);
        }
    }
}
