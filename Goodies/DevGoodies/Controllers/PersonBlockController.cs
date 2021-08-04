namespace DevGoodies.Controllers
{
    using EPiServer.Web.Mvc;

    using DevGoodies.ViewModels;
    using DevGoodies.Models.Blocks;

    using System.Web.Mvc;

    public class PersonBlockController : BlockController<PersonBlock>
    {
        //-----------------------------------------------------------------------------------------------------//
        //                                           ACTION METHODS                                            //
        //-----------------------------------------------------------------------------------------------------//
        public override ActionResult Index(PersonBlock currentBlock)
        {
            PersonBlockViewModel viewModel = new PersonBlockViewModel
            {
                CurrentBlock = currentBlock,
            };

            return PartialView(viewModel);
        }
    }
}
