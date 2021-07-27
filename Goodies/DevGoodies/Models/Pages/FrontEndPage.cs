namespace DevGoodies.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System.ComponentModel.DataAnnotations;

    [AvailableContentTypes(Include = new[] { typeof(ResourcesPage) })]
    [ContentType(DisplayName = "Front-End", GUID = "2b2f2fdd-cc90-4649-8777-3966546600f4", GroupName = Groups.FrontEnd, Order = 10,
                 Description = "A Front-End main category page for the website.")]
    public class FrontEndPage : BasePage
    {
        [CultureSpecific]
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 10,
                 Description = "The Main content area of the page. Can contain blocks, media assets, and pages.")]
        public virtual ContentArea MainContentArea { get; set; }
    }
}