using System.Collections.Generic;
using System.Data;
using System.Linq;
using AstroDataService.Constants;
using AstroDataService.DataAccess;
using AstroDataService.Models;
using Dapper;

namespace AstroDataService.Query
{
    public class GetAllPlanetDataQuery : IGetAllPlanetDataQuery
    {
        private readonly IAstroDataContext _dbContext;
        private readonly string _sql = $@"SELECT Id,
                                                 Name,
                                                 Description,
                                                 Distance_From_Sun_KM DistanceFromSunKm,
                                                 Diameter_KM DiameterKm
                                          FROM {TableNames.PlanetsTable}";

        public GetAllPlanetDataQuery(IAstroDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Planet> GetAllPlanetData()
        {
            return _dbContext.Connection.Query<Planet>(_sql).ToList();
        }
    }
}