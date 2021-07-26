namespace DevGoodies.Business.ExtensionMethods
{
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.ServiceLocation;

    using System.Linq;

    public static class SectionExtensionMethods
    {
        // Gets the top level page of the section this page is in. Used to build our submenu.
        public static IContent GetSection(this ContentReference contentLink)
        {
            IContentLoader loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            IContent currentContent = loader.Get<IContent>(contentLink);
            if (currentContent.ParentLink != null && currentContent.ParentLink.CompareToIgnoreWorkID(ContentReference.StartPage))
            {
                return currentContent;
            }

            return loader.GetAncestors(contentLink)
                         .OfType<PageData>()
                         .SkipWhile(x => x.ParentLink == null || !x.ParentLink.CompareToIgnoreWorkID(ContentReference.StartPage))
                         .FirstOrDefault();
        }
    }
}