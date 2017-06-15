namespace AstroDataService.Service.Ping
{
    public class PingService : ServiceStack.Service
    {
        public PingResponse Get(PingRequest pingRequest)
        {
            return new PingResponse();
        }
    }
}