using System.Reflection;
using AstroDataService.DataAccess;
using AstroDataService.Ioc;
using ServiceStack;
using StructureMap;
using Container = Funq.Container;

namespace AstroDataService.Hosting
{
    public class AppHost : AppHostHttpListenerBase
    {
        public AppHost() :
            base("Astro_Data_Service", typeof(AppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            var iocContainer = ContainerBuilder.CreateContainer();
            container.Adapter = new StructureMapContainerAdaptor(iocContainer);

            ConfigureDatabase(iocContainer);
        }

        private void ConfigureDatabase(IContainer container)
        {
            var dbContext = container.GetInstance<IAstroDataContext>();
            var seedDataGenerator = container.GetInstance<IAstroSeedDataGenerator>();
            seedDataGenerator.GenerateSeedData();
        }
    }
}