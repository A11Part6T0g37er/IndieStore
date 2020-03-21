using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace DomainModel.Explicit_Realization
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext db)
        {
            db.Games.Add(new Game {Name = "DOOM:Eteranal",Price = 99,Categories = { new Category() { Name = "Shooter" } }, Description = "Shoot`em all with no mercy!" , GameId = 1 });
            db.Games.Add(new Game { Name = "Civ VI", Price = 999, Categories = { new Category { Name = "Strategy" } , new Category { Name = "4X" } }, Description = "Build`em up!" , GameId = 2});
            db.SaveChanges();
        }
    }
}
