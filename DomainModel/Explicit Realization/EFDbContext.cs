using System.Data.Entity;

namespace DomainModel.Explicit_Realization
{
    public class EFDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}