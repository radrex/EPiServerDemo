namespace DevGoodies.Business.DependencyResolvers
{
    using StructureMap;

    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Collections.Generic;

    public class StructureMapDependencyResolver : IDependencyResolver
    {
        //---------------- FIELDS -----------------
        private readonly IContainer container;

        //------------- CONSTRUCTORS --------------
        public StructureMapDependencyResolver(IContainer container)
        {
            this.container = container;
        }

        //---------------- METHODS ----------------
        public object GetService(Type serviceType)
        {
            if (serviceType.IsInterface || serviceType.IsAbstract)
            {
                return GetInterfaceService(serviceType);
            }
            return GetConcreteService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.container.GetAllInstances(serviceType).Cast<object>();
        }

        private object GetConcreteService(Type serviceType)
        {
            return this.container.GetInstance(serviceType);
        }

        private object GetInterfaceService(Type serviceType)
        {
            return this.container.TryGetInstance(serviceType);
        }
    }
}