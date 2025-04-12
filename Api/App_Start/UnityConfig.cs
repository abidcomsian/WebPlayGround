using System.Web.Http;
using Unity.WebApi;

namespace OweWay.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = Bootstrapper.Bootstrapper.Initialize();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}