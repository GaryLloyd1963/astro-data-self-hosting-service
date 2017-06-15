using System.Data.Entity;

namespace AstroDataService.DataAccess.Planets
{
    public interface IPlanetModelBuilder
    {
        void BuildModel(DbModelBuilder modelBuilder);
    }
}