namespace DevGoodies.Models.Blocks
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System;
    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "AuthorBlock", GUID = "fb106088-79a7-4988-9279-abf94c09a7c5", GroupName = Groups.Blocks, Order = 10,
                 Description = "Block for storing information about an Author of an item.")]
    public class AuthorBlock : BlockData
    {
        [Display(Name = "First name", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string FirstName { get; set; }

        [Display(Name = "Last name", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string LastName { get; set; }

        [Display(Name = "Hire date", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual DateTime? HireDate { get; set; }

        [Display(Name = "Main content area", GroupName = SystemTabNames.Content, Order = 40, Description = "The main content area contains an ordered collection to content reference, for example blocks, media assets, and pages.")]
        public virtual ContentArea MainContentArea { get; set; }
    }
}