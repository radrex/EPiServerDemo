namespace DevGoodies.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    
    using DevGoodies.Business.Constants;

    using System.ComponentModel.DataAnnotations;

    [AvailableContentTypes(Include = new[] { typeof(ResourcesPage) })]
    [ContentType(DisplayName = "Back-End", GUID = "7091011d-1a3a-4224-abb0-b2e328a1851a", GroupName = Groups.BackEnd, Order = 10,
                 Description = "A Back-End main category page for the website.")]
    public class BackEndPage : BasePage
    {
        [CultureSpecific]
        [Display(Name = "Main Content Area", GroupName = SystemTabNames.Content, Order = 10,
                 Description = "The Main content area of the page. Can contain blocks, media assets, and pages.")]
        public virtual ContentArea MainContentArea { get; set; }
    }
}