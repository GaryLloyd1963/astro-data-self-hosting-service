using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using AstroDataService.Constants;
using AstroDataService.Models;

namespace AstroDataService.DataAccess.Planets
{
    public class PlanetModelBuilder : IPlanetModelBuilder
    {
        public void BuildModel(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().ToTable(TableNames.PlanetsTable);
            modelBuilder.Entity<Planet>().Property(planet => planet.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Planet>().Property(planet => planet.Name).IsRequired();
            modelBuilder.Entity<Planet>().Property(planet => planet.DistanceFromSunKm).HasColumnName("Distance_From_Sun_KM");
            modelBuilder.Entity<Planet>().Property(planet => planet.DiameterKm).HasColumnName("Diameter_KM");
        }
    }
}