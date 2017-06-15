using AstroDataService.Hosting;
using Topshelf;

namespace AstroDataService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<AstroDataServiceObject>(s => 
                {
                    s.ConstructUsing(name => new AstroDataServiceObject(new AppHost()));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDescription("Astro Data Service Hosted by Topshelf");
                x.SetDisplayName("Astro Data Service");
                x.SetServiceName("Astro_Data_Service");
            });
        }
    }
}
