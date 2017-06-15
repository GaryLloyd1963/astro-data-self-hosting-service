using System;
using ServiceStack;

namespace AstroDataService.Hosting
{
    public class AstroDataServiceObject
    {
        private AppHostHttpListenerBase _appHost;

        public AstroDataServiceObject(AppHostHttpListenerBase appHost)
        {
            _appHost = appHost;
        }

        public void Start()
        {
            _appHost.Init();
            _appHost.Start("http://localhost:3334/astro-data/");
            Console.WriteLine("Astro Data Service : Start");
        }

        public void Stop()
        {
            if (_appHost.HasStarted)
                _appHost.Stop();
            _appHost.Dispose();
            Console.WriteLine("Astro Data Service : Stop");
        }
    }
}