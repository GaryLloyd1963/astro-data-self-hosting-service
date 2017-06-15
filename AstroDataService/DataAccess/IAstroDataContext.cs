using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using AstroDataService.Models;

namespace AstroDataService.DataAccess
{
    public interface IAstroDataContext : IDisposable
    {
        IDbConnection Connection { get; }

        IDbSet<Planet> Planets { get; set; }

        IQueryable<T> AstroDataSet<T>() where T : class;
        bool AstroDataSetExists<T>() where T : class;

        int SaveChanges();
    }
}