namespace DevGoodies.ViewModels
{
    using EPiServer.Core;

    using DevGoodies.Models.Pages;

    public class PreviewPageViewModel : PageViewModel<BasePage>
    {
        //------------- CONSTRUCTORS --------------
        public PreviewPageViewModel(BasePage currentPage, IContent previewContent) : base(currentPage)
        {
            this.PreviewArea = new ContentArea();
            this.PreviewArea.Items.Add(new ContentAreaItem { ContentLink = previewContent.ContentLink });
        }

        //-------------- PROPERTIES ---------------
        public ContentArea PreviewArea { get; set; }
    }
}