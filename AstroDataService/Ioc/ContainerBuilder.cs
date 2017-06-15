using AstroDataService.DataAccess;
using StructureMap;
using StructureMap.Pipeline;

namespace AstroDataService.Ioc
{
    public class ContainerBuilder
    {
        public static Container CreateContainer()
        {
            return new Container(c =>
            {
                c.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.WithDefaultConventions();
                });

                c.For<IAstroDataContext>().LifecycleIs<SingletonLifecycle>();
            });
        }
    }
}