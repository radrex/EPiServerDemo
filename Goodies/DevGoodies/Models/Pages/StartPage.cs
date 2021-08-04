namespace DevGoodies.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Models.Media;
    using DevGoodies.Models.Blocks;
    using DevGoodies.Business.Constants;

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [AvailableContentTypes(Include = new[] { typeof(BackEndPage), typeof(FrontEndPage), typeof(GeneralPage) })]
    [ContentType(DisplayName = "Home", GUID = "49731d25-4e5e-42f9-84fa-c8e1fe423b9a", GroupName = Groups.Specialized, Order = 10,
                 Description = "A Home page for a website.")]
    public class StartPage : BasePage
    {
        [CultureSpecific]
        [Display(Name = "Heading", GroupName = SystemTabNames.Content, Order = 10,
                 Description = "If the Heading is not set, the page falls back to showing the Name.")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body", GroupName = SystemTabNames.Content, Order = 20, 
                 Description = "The main body uses the XHTML-editor you can insert for example text, images and tables.")]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [AllowedTypes(typeof(BlockData), typeof(ImageData), typeof(ContentFolder), typeof(PDFFile))]
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 30,
                 Description = "The Main content area of the page. Can contain blocks, media assets, and pages.")]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [AllowedTypes(typeof(EventBlock))]
        [Display(Name = "Event list as content area", GroupName = Tabs.Events, Order = 10,
                 Description = "Can contain only EventBlock.")]
        public virtual ContentArea EventListContentArea { get; set; }

        [CultureSpecific]
        [AllowedTypes(typeof(EventBlock))]
        [Display(Name = "Event list as a list of content references", GroupName = Tabs.Events, Order = 20,
                 Description = "Can contain only EventBlock.")]
        public virtual IList<ContentReference> EventListContentReferences { get; set; }

        [CultureSpecific]
        [AllowedTypes(typeof(ContentFolder))]
        [Display(Name = "Event list as reference to assets folder", GroupName = Tabs.Events, Order = 30,
                 Description = "Can contain only EventBlock.")]
        public virtual ContentReference EventListAssetsFolderReference { get; set; }
    }
}