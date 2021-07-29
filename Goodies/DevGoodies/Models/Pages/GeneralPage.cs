namespace DevGoodies.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;
    
    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "General Page", GUID = "fd8952de-ac5d-48b6-a0e4-7fbbb1c14eff", GroupName = Groups.General, Order = 10,
                 Description = "A general page.")]
    public class GeneralPage : BasePage
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
        [AllowedTypes(typeof(PageData), typeof(ContentFolder), typeof(BlockData))]
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 30,
         Description = "The Main content area of the page. Can contain pages, folders and blocks.")]
        public virtual ContentArea MainContentArea { get; set; }
    }
}