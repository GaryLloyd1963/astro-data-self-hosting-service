using AstroDataService.Query;

namespace AstroDataService.Service.Planets
{
    public class GetAllPlanetDataService : ServiceStack.Service
    {
        private readonly IGetAllPlanetDataQuery _query;

        public GetAllPlanetDataService(IGetAllPlanetDataQuery query)
        {
            _query = query;
        }

        public GetAllPlanetDataResponse Get(GetAllPlanetDataRequest request)
        {
            var planetData = _query.GetAllPlanetData();
            return new GetAllPlanetDataResponse
            {
                PlanetInfo = planetData
            };
        }
    }
}