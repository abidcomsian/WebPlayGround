using OweWay.Application.Contracts;
using OweWay.Infrastructure.Nlogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity;
using Unity.Lifetime;

namespace OweWay.Bootstrapper
{
    public static class Bootstrapper
    {
        private static Assembly[] _owewayAssembelies;
        public static UnityContainer Initialize()
        {
            _owewayAssembelies = GetOweWayAssemblies();
            var container = new UnityContainer();
            container.AddInfrasturcture();
            container.AddApplication();
            return container;
        }
        private static IUnityContainer AddInfrasturcture(this IUnityContainer container)
        {
            container.RegisterType<ILoggerService, NLogLoggerService>(new ContainerControlledLifetimeManager());
            var repositoryInterfaceType = typeof(IRepository<>);
            RegisterTypes(container, repositoryInterfaceType, new HierarchicalLifetimeManager());
            return container;
        }

        private static IUnityContainer AddApplication(this IUnityContainer container)
        {
            container.RegisterAppServices();
            return container;
        }

        private static void RegisterTypes(this IUnityContainer container, Type type, ITypeLifetimeManager lifetimeManager)
        {
            var implementedTypes = _owewayAssembelies.SelectMany(s => s.GetTypes()
                   .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == type) && !t.IsAbstract));
            foreach (var implementationType in implementedTypes)
            {
                var implementedInterfaces = implementationType.GetInterfaces()
                    .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == type);

                foreach (var implementedInterface in implementedInterfaces)
                {
                    container.RegisterType(implementedInterface, implementationType, lifetimeManager);
                }
            }
        }

        private static void RegisterAppServices(this IUnityContainer container)
        {
            var assemblyTypes = _owewayAssembelies.SelectMany(a => a.GetTypes());
            var servicePairs = assemblyTypes.Where(type => type.IsClass && !type.IsAbstract)
           .SelectMany(type =>
               type.GetInterfaces()
                   .Where(i => i.Name.StartsWith("I") && i.Name.EndsWith("Service") && !i.Name.Equals("ILoggerService"))
                   .Select(i => new { Interface = i, Implementation = type }))
           .ToList();

            foreach (var pair in servicePairs)
            {
                container.RegisterType(pair.Interface, pair.Implementation, new HierarchicalLifetimeManager());
            }
        }

        private static Assembly[] GetOweWayAssemblies() => AppDomain.CurrentDomain.GetAssemblies()
                 .Where(a => !a.IsDynamic && a.GetName().Name.StartsWith("OweWay", StringComparison.OrdinalIgnoreCase))
                 .ToArray();
    }
}
