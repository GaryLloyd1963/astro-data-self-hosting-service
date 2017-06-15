using System.Data.Entity;

namespace AstroDataService.DataAccess
{
    public interface IAstroSeedDataGenerator
    {
        void GenerateSeedData();
    }
}