namespace DevGoodies.Models.Blocks
{
    using EPiServer.Web;
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System;
    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "PersonalBlock", GUID = "fed4c668-9265-43a8-8920-93f18872dd6d", GroupName = Groups.Specialized, Order = 10,
                 Description = "Personal block.")]
    public class PersonalBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "First Name", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string FirstName { get; set; }

        [CultureSpecific]
        [Display(Name = "Last Name", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string LastName { get; set; }

        [CultureSpecific]
        [Display(Name = "Birth date", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual DateTime BirthDate { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        [Display(Name = "Summary", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual string Summary { get; set; }
    }
}