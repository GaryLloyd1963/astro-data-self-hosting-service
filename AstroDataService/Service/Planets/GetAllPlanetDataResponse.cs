using System.Collections;
using System.Collections.Generic;
using AstroDataService.Models;

namespace AstroDataService.Service.Planets
{
    public class GetAllPlanetDataResponse
    {
        public IList<Planet> PlanetInfo { get; set; }
    }
}