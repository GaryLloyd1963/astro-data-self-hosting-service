using System.Data.Entity;
using AstroDataService.DataAccess.Planets;

namespace AstroDataService.DataAccess
{
    public class AstroSeedDataGenerator : IAstroSeedDataGenerator
    {
        private readonly IPlanetSeedDataGenerator _planetSeedDataGenerator;

        public AstroSeedDataGenerator(IPlanetSeedDataGenerator planetSeedDataGenerator)
        {
            _planetSeedDataGenerator = planetSeedDataGenerator;
        }
        public void GenerateSeedData()
        {
            _planetSeedDataGenerator.GenerateSeedData();
        }
    }
}