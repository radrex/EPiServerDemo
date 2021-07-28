namespace DevGoodies.Initialization
{
    using EPiServer.Framework;
    using EPiServer.ServiceLocation;
    using EPiServer.Framework.Initialization;

    using DevGoodies.Business.DependencyResolvers;

    using System.Web.Mvc;

    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterDependencyResolverInitializationModule : IConfigurableModule
    {
        //---------------- METHODS ----------------

        // Here you can add statements to replace Episerver services like IContentLoader with your own implementations, where you can register your own custom services.
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.StructureMap()));

            // Implementations for custom interfaces can be registered here.
            context.ConfigurationComplete += (o, e) =>
            {
                // Register custom implementations that should be used in favour of the default implementations
            };
        }

        public void Initialize(InitializationEngine context) { }
        public void Uninitialize(InitializationEngine context) { }
    }
}