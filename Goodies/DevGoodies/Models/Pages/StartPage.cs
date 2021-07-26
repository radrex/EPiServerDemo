namespace DevGoodies.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 30,
                 Description = "The Main content area of the page. Can contain blocks, media assets, and pages.")]
        public virtual ContentArea MainContentArea { get; set; }
    }
}