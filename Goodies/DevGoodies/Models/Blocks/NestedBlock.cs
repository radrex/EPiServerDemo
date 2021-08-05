namespace DevGoodies.Models.Blocks
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "Nested", GUID = "e11c18ea-cad7-445e-a540-f61ff2b23a51", GroupName = Groups.Blocks, Order = 40,
                 Description = "Block with option for nesting another block")]
    public class NestedBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Main Block Title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }

        [Display(Name = "Block content area", GroupName = SystemTabNames.Content, Order = 20, 
                 Description = "For nesting blocks other blocks")]
        public virtual ContentArea BlockContentArea { get; set; }
    }
}