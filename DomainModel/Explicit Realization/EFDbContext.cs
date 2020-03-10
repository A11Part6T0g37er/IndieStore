using System;
using System.Data.Entity;
using System.Linq;

namespace DomainModel.Explicit_Realization
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}