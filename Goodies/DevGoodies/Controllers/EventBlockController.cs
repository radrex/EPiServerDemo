namespace DevGoodies.Controllers
{
    using EPiServer.Web.Mvc;

    using DevGoodies.Models.Blocks;

    using System.Web.Mvc;
    using DevGoodies.ViewModels;

    public class EventBlockController : BlockController<EventBlock>
    {
        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public override ActionResult Index(EventBlock currentBlock)
        {
            EventBlockViewModel viewModel = new EventBlockViewModel
            {
                CurrentBlock = currentBlock,
            };

            return PartialView(viewModel);
        }
    }
}
