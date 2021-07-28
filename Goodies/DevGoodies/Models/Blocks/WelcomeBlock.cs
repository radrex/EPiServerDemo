namespace DevGoodies.Models.Blocks
{
    using EPiServer.Web;
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;
    
    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "WelcomeBlock", GUID = "251ff436-86ac-4f5a-966b-0f2326bcb313", GroupName = Groups.Specialized, Order = 10,
                 Description = "Block for rich text with heading, image and page link that will be reused in multiple places.")]
    public class WelcomeBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading", GroupName = SystemTabNames.PageHeader, Order = 10)]
        public virtual string WelcomeHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Rich text", Order = 20)]
        public virtual XhtmlString WelcomeText { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Image", GroupName = SystemTabNames.PageHeader, Order = 30)]
        public virtual ContentReference WelcomeImage { get; set; }

        [Display(Name = "Link", GroupName = SystemTabNames.PageHeader, Order = 40)]
        public virtual PageReference WelcomeLink { get; set; }
    }
}