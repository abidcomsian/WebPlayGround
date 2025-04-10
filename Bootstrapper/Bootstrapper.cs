using Application.Mapper;
using Unity;

namespace OweWay.Bootstrapper
{
    public static class Bootstrapper
    {
        public static UnityContainer Initialize()
        {
            var container = new UnityContainer();
            container.AddInfrasturcture();
            return container;
        }

        private static IUnityContainer AddInfrasturcture(this IUnityContainer container)
        {
            //container.RegisterType(typeof(IMapper<,>), typeof(Repository<>));


            return container;
        }
    }
}
