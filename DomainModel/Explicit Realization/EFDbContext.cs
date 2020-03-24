using DomainModel.Models;
using System.Data.Entity;

namespace DomainModel.Explicit_Realization
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("DefaultConnection") 
        {
            
        }
        static EFDbContext()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public EFDbContext(string connectionString)
           : base(connectionString)
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void Dispose(bool disposing)
        {
           
            base.Dispose(disposing);
        }
    }
}