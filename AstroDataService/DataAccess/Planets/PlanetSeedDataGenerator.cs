using System.Linq;
using AstroDataService.Models;

namespace AstroDataService.DataAccess.Planets
{
    public class PlanetSeedDataGenerator : IPlanetSeedDataGenerator
    {
        private readonly IAstroDataContext _dbContext;

        public PlanetSeedDataGenerator(IAstroDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void GenerateSeedData()
        {
            if (_dbContext.AstroDataSetExists<Planet>())
                return;

            SeedPlanetData.seedPlanetData.ForEach(planet => _dbContext.Planets.Add(planet));
            _dbContext.SaveChanges();
        }
    }
}