using System.Data;
using System.Data.Entity;
using System.Linq;
using AstroDataService.DataAccess.Planets;
using AstroDataService.Models;

namespace AstroDataService.DataAccess
{
    public class AstroDataContext : DbContext, IAstroDataContext
    {
        private readonly IPlanetModelBuilder _planetModelBuilder;

        public AstroDataContext(IPlanetModelBuilder planetModelBuilder)
            : base("Name=AstroData")
        {
            _planetModelBuilder = planetModelBuilder;

            //Database.SetInitializer(new CreateDatabaseIfNotExists<AstroDataContext>());
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            _planetModelBuilder.BuildModel(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public IDbConnection Connection => Database.Connection;

        public IDbSet<Planet> Planets { get; set; }

        public IQueryable<T> AstroDataSet<T>() where T : class
        {
            return Set<T>();
        }

        public bool AstroDataSetExists<T>() where T : class
        {
            return AstroDataSet<T>().Any();
        }
    }
}
