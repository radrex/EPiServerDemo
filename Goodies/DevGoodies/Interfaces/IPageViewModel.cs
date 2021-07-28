namespace DevGoodies.Interfaces
{
    using EPiServer.Core;

    using DevGoodies.Models.Pages;

    using System.Collections.Generic;

    public interface IPageViewModel<out T> where T : BasePage
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }
        IEnumerable<BasePage> Children { get; }
        Dictionary<string, List<string>> PageURLs { get; }
        IContent Section { get; } // Used to reference the page that is shown in the top-level navigation menu.
    }
}