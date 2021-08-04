namespace DevGoodies.Models.Blocks
{
    using EPiServer.Web;
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System.ComponentModel.DataAnnotations;
    using System;

    [ContentType(DisplayName = "Person", GUID = "80f58fd5-70d3-452a-b21a-6e860e4de3e7", GroupName = Groups.Blocks, Order = 40,
                 Description = "Block for Person information.")]
    public class PersonBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "First Name", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string FirstName { get; set; }

        [CultureSpecific]
        [Display(Name = "Last Name", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string LastName { get; set; }

        [CultureSpecific]
        [Display(Name = "Birth Date", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual DateTime? BirthDate { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        [Display(Name = "Summary", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual string Summary { get; set; }
    }
}