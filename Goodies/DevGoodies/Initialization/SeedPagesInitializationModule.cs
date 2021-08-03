namespace DevGoodies.Initialization
{
    using EPiServer;
    using EPiServer.Web;
    using EPiServer.Core;
    using EPiServer.Filters;
    using EPiServer.Security;
    using EPiServer.Framework;
    using EPiServer.DataAccess;
    using EPiServer.Framework.Initialization;

    using DevGoodies.Models.Pages;

    using System.Linq;
    using System.Configuration;
    using System.Globalization;

    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))] // For order of execution - typeof(MyModule) will be initialized before our module
    public class SeedPagesInitializationModule : IInitializableModule
    {
        //---------------- METHODS ----------------
        public void Initialize(InitializationEngine context)
        {
            // this returns empty if one of your sites does not have a * wildcard hostname
            ContentReference startReference = ContentReference.StartPage;

            // we can use the site definition repo to get the first site's start page instead
            if (ContentReference.IsNullOrEmpty(startReference))
            {
                ISiteDefinitionRepository siteRepo = context.Locate.Advanced.GetInstance<ISiteDefinitionRepository>();
                SiteDefinition firstSite = siteRepo.List().FirstOrDefault();
                if (firstSite is null) return; // if no sites, give up running this module
                startReference = firstSite.StartPage;
            }

            string enabledString = ConfigurationManager.AppSettings["dev:SeedPages"];
            if (bool.TryParse(enabledString, out bool enabled))
            {
                if (enabled)
                {
                    IContentRepository repo = context.Locate.Advanced.GetInstance<IContentRepository>();

                    // Seed Back-End page
                    BackEndPage backEnd;
                    IContent content = repo.GetBySegment(startReference, "back-end", CultureInfo.GetCultureInfo("en"));
                    if (content is null)
                    {
                        backEnd = repo.GetDefault<BackEndPage>(startReference);
                        backEnd.Name = "Back-End";
                        backEnd.MetaTitle = "Back-End";
                        backEnd.MetaKeywords = "back-end,c#,java,db";
                        backEnd.OgTypes = "website";
                        backEnd.MetaDescription = "A web page containing different Back-End valuable resources for developers.";
                        //backEnd.SortIndex = 400;
                        repo.Save(backEnd, SaveAction.Publish, AccessLevel.NoAccess);

                        // Seed Resources page for Back-End
                        ResourcesPage resources;
                        resources = repo.GetDefault<ResourcesPage>(backEnd.ContentLink);
                        resources.Name = "Resources";
                        resources.MetaTitle = "Back-End resources";
                        resources.MetaKeywords = "back-end-resources";
                        resources.OgTypes = "website";
                        resources.MetaDescription = "Back-End valuable resources list.";
                        repo.Save(resources, SaveAction.Publish, AccessLevel.NoAccess);
                    }

                    // Seed Front-End page
                    FrontEndPage frontEnd;
                    content = repo.GetBySegment(startReference, "front-end", CultureInfo.GetCultureInfo("en"));
                    if (content is null)
                    {
                        frontEnd = repo.GetDefault<FrontEndPage>(startReference);
                        frontEnd.Name = "Front-End";
                        frontEnd.MetaTitle = "Front-End";
                        frontEnd.MetaKeywords = "front-end,html5,css3,js";
                        frontEnd.OgTypes = "website";
                        frontEnd.MetaDescription = "A web page containing different Front-End valuable resources for developers.";
                        //frontEnd.SortIndex = 300;
                        repo.Save(frontEnd, SaveAction.Publish, AccessLevel.NoAccess);

                        // Seed Resources page for Front-End
                        ResourcesPage resources;
                        resources = repo.GetDefault<ResourcesPage>(frontEnd.ContentLink);
                        resources.Name = "Resources";
                        resources.MetaTitle = "Front-End resources";
                        resources.MetaKeywords = "front-end-resources";
                        resources.OgTypes = "website";
                        resources.MetaDescription = "Front-End valuable resources list.";
                        repo.Save(resources, SaveAction.Publish, AccessLevel.NoAccess);
                    }


                    // change Start page sort order for children
                    if (repo.Get<StartPage>(startReference).CreateWritableClone() is StartPage startPage)
                    {
                        startPage.ChildSortOrder = FilterSortOrder.Index;
                        repo.Save(startPage, SaveAction.Publish, AccessLevel.NoAccess);
                    }
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}