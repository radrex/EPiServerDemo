namespace DevGoodies.ViewModels
{
    using EPiServer.Core;
    using System.Collections.Generic;

    public class ListingBlockViewModel
    {
        public string Heading { get; set; }
        public IEnumerable<PageData> Pages { get; set; }
    }
}