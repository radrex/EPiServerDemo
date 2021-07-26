namespace DevGoodies.Models.Pages
{
    using EPiServer.Web;
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    using EPiServer.Shell.ObjectEditing;

    using DevGoodies.Business.Constants;
    using DevGoodies.Business.SelectionFactories;

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public abstract class BasePage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Meta title", GroupName = Tabs.SEO, Order = 100)]
        [StringLength(60, MinimumLength = 5)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta keywords", GroupName = Tabs.SEO, Order = 200)]
        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta description", GroupName = Tabs.SEO, Order = 300)]
        [UIHint(UIHint.Textarea)] // Multi-row text editor
        public virtual string MetaDescription { get; set; }

        [CultureSpecific]
        [Display(Name = "Page image", GroupName = SystemTabNames.Content, Order = 100)]
        [UIHint(UIHint.Image)] // Filters to only show images
        public virtual ContentReference PageImage { get; set; }

        //[Display(Name = "Open Graph type", GroupName = Tabs.SEO, Order = 400)]
        //[SelectOne(SelectionFactoryType = typeof(OGTypeSelectionFactory))]
        // How to do it with custom attributes ?
        // [OGTypeSelectionAttribute(OGType="Article")]
        //public virtual string OgType { get; set; }

        [Display(Name = "Open Graph types", GroupName = Tabs.SEO, Order = 400)]
        [SelectMany(SelectionFactoryType = typeof(OGTypeSelectionFactory))]
        public virtual string OgTypes { get; set; }
    }
}