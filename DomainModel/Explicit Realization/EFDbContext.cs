using System.Data.Entity;

namespace DomainModel.Explicit_Realization
{
    public class EFDbContext : DbContext
    {
        static EFDbContext()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public EFDbContext(string connectionString)
           : base(connectionString)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}