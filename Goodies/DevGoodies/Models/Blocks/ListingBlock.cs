namespace DevGoodies.Models.Blocks
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;
    
    using DevGoodies.Business.Constants;
    
    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "Listing", GUID = "e328abad-4072-402f-87fe-22f0ea9d97fa", GroupName = Groups.General,
                 Description = "Choose a page in a tree, and its children will be listed, with a heading.")]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }

        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference Children { get; set; }
    }
}