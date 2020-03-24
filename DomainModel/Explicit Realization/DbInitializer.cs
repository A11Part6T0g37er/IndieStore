using DomainModel.Models;
using System.Data.Entity;

namespace DomainModel.Explicit_Realization
{
    public class DbInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext db)
        {
            Category shooter = new Category() { Name = "Shooter" };
            Game doom = new Game()
            {
                Name = "DOOM:Eteranal",
                Price = 99,
               Categories = { shooter },
          //  Category = shooter,
                Description = "Shoot`em all with no mercy!"
            };
            Category strategy = new Category { Name = "Strategy" };
            Category strategy4x = new Category { Name = "4X" };
            Game civ = new Game()
            {
                Name = "Civ VI",
                Price = 999,
                      Categories = {
                           strategy,
                           strategy4x }, 
              
              //  Category = strategy,
                Description = "Build`em up!" 
            };
            db.Games.Add(doom);
            db.Games.Add(civ);
            db.SaveChanges();

            base.Seed(db);
        }
    }
}
