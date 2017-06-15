using System.Collections.Generic;
using AstroDataService.Models;

namespace AstroDataService.Query
{
    public interface IGetAllPlanetDataQuery
    {
        List<Planet> GetAllPlanetData();
    }
}