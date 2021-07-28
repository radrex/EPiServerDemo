namespace DevGoodies.Business.ExtensionMethods
{
    using EPiServer;
    using EPiServer.Core;
    using EPiServer.ServiceLocation;

    using System;
    using System.Text;

    public static class MiscExtensions
    {
        //---------------- METHODS ----------------
        public static string ExternalURLFromReference(this ContentReference contentLink)
        {
            IContentLoader loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            PageData page = loader.Get<PageData>(contentLink);
            UrlBuilder pageURLBuilder = new UrlBuilder(page.LinkURL);
            Global.UrlRewriteProvider.ConvertToExternal(pageURLBuilder, page.PageLink, UTF8Encoding.UTF8);

            string pageURL = pageURLBuilder.ToString();
            UriBuilder uriBuilder = new UriBuilder(EPiServer.Web.SiteDefinition.Current.SiteUrl)
            {
                Path = pageURL
            };
            return uriBuilder.Uri.AbsoluteUri;
        }
    }
}