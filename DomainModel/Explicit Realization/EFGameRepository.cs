using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DomainModel.Explicit_Realization
{
    class EFGameRepository : IGamesRepository
    {
        EFDbContext context;

        public EFGameRepository()
        {
              }

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }

       

        public void SaveGame(Game game)
        {
            if (game.Id == 0)
                context.Games.Add(game);
            else
            {
                Game dbEntry = context.Games.Find(game.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = game.Name;
                    dbEntry.Description = game.Description;
                    dbEntry.Price = game.Price;
                    dbEntry.Categories = game.Categories;
                    dbEntry.ImageData = game.ImageData;
                    dbEntry.ImageMimeType = game.ImageMimeType;
                }
            }
            context.SaveChanges();
        }


        public /*Game*/ void DeleteGame(int gameId)
        {
            Game dbEntry = context.Games.Find(gameId);
            if (dbEntry != null)
            {
                context.Games.Remove(dbEntry);
                context.SaveChanges();
            }
          //  return dbEntry;
        }

        public IEnumerable<Game> GetGamesList()
        {
            return context.Games.ToList();
        }

       
    }
}
