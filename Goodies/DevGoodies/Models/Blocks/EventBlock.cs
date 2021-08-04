namespace DevGoodies.Models.Blocks
{
    using EPiServer.Core;
    using EPiServer.DataAbstraction;
    using EPiServer.DataAnnotations;

    using DevGoodies.Business.Constants;

    using System;
    using System.ComponentModel.DataAnnotations;

    [ContentType(DisplayName = "Event", GUID = "02529b45-9f40-4575-8442-b82c19900476", GroupName = Groups.Blocks, Order = 30,
                 Description = "Block for events.")]
    public class EventBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "Where", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string Where { get; set; }

        [CultureSpecific]
        [Display(Name = "Hire date", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual DateTime? When { get; set; }

        [CultureSpecific]
        [Display(Name = "Description", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual string Description { get; set; }
    }
}