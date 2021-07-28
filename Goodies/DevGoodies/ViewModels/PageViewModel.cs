namespace DevGoodies.ViewModels
{
    using EPiServer.Core;

    using DevGoodies.Interfaces;
    using DevGoodies.Models.Pages;

    using System;
    using System.Collections.Generic;

    public class PageViewModel<T> : IPageViewModel<T> where T : BasePage
    {
        //-------------- PROPERTIES ---------------
        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<BasePage> Children { get; set; }
        public Dictionary<string, List<string>> PageURLs { get; set; }
        public IContent Section { get; set; }

        //------------- CONSTRUCTORS --------------
        public PageViewModel(T currentPage)
        {
            this.CurrentPage = currentPage;
            this.PageURLs = new Dictionary<string, List<string>>();
        }
    }

    public static class PageViewModel
    {
        //---------------- METHODS ----------------

        // A convenient method for creating PageViewModel instances without having to specify the type, because generic methods can use type inference while constructors cannot.
        public static PageViewModel<T> Create<T>(T currentPage) where T : BasePage
        {
            return new PageViewModel<T>(currentPage);
        }
    }
} 