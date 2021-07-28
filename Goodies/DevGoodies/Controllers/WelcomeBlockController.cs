namespace DevGoodies.Controllers
{
    using EPiServer.Web.Mvc;

    using DevGoodies.ViewModels;
    using DevGoodies.Models.Blocks;
    
    using System.Web.Mvc;

    public class WelcomeBlockController : BlockController<WelcomeBlock>
    {
        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public override ActionResult Index(WelcomeBlock currentBlock)
        {
            WelcomeBlockViewModel viewModel = new WelcomeBlockViewModel
            {
                CurrentBlock = currentBlock,
                Description = "Lorem ipsum",
            };

            return PartialView(viewModel);
        }
    }
}
