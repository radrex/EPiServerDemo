namespace DevGoodies.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "ResourcesPage", GUID = "213acc32-4fb1-414b-8aee-bbe75f44d0a9", GroupName = Groups.Specialized, Order = 20,
                 Description = "A Resources page for the website.")]
    public class ResourcesPage : BasePage
    {
        [CultureSpecific]
        [Display(Name = "Heading", GroupName = SystemTabNames.Content, Order = 10,
         Description = "If the Heading is not set, the page falls back to showing the Name.")]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body", GroupName = SystemTabNames.Content, Order = 20,
                 Description = "The main body uses the XHTML-editor you can insert for example text, images and tables.")]
        public virtual XhtmlString MainBody { get; set; }
    }
}