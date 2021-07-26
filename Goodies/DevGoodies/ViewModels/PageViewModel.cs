namespace DevGoodies.ViewModels
{
    using EPiServer.Core;

    using DevGoodies.Interfaces;
    using DevGoodies.Models.Pages;

    using System.Collections.Generic;

    public class PageViewModel<T> : IPageViewModel<T> where T : BasePage
    {
        //-------------- PROPERTIES ---------------
        public T CurrentPage { get; set; }
        public StartPage StartPage { get; set; }
        public IEnumerable<BasePage> MenuPages { get; set; }
        public IContent Section { get; set; }

        //------------- CONSTRUCTORS --------------
        public PageViewModel(T currentPage)
        {
            this.CurrentPage = currentPage;
        }
    }

    public static class PageViewModel
    {
        // A convenient method for creating PageViewModel instances without having to specify the type, because generic methods can use type inference while constructors cannot.
        public static PageViewModel<T> Create<T>(T currentPage) where T : BasePage
        {
            return new PageViewModel<T>(currentPage);
        }
    }
} 