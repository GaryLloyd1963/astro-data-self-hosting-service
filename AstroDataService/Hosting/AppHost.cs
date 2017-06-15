using System.Reflection;
using AstroDataService.DataAccess;
using AstroDataService.Ioc;
using Funq;
using ServiceStack;

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

        private void ConfigureDatabase(StructureMap.Container container)
        {
            var dbContext = container.GetInstance<IAstroDataContext>();
            var seedDataGenerator = container.GetInstance<IAstroSeedDataGenerator>();
            seedDataGenerator.GenerateSeedData();
        }
    }
}