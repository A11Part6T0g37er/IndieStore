using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace DomainModel.Explicit_Realization
{
    class EFGameRepository : IItemsRepository<IGoods>
    {
        EFDbContext context;

        public EFGameRepository()
        {
              }

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }

        public IEnumerable<IGoods> Items => throw new NotImplementedException();

        public void SaveGame(Game game)
        {
            if (game.GameId == 0)
                context.Games.Add(game);
            else
            {
                Game dbEntry = context.Games.Find(game.GameId);
                if (dbEntry != null)
                {
                    dbEntry.Name = game.Name;
                    dbEntry.Description = game.Description;
                    dbEntry.Price = game.Price;
                    dbEntry.Category = game.Category;
                    dbEntry.ImageData = game.ImageData;
                    dbEntry.ImageMimeType = game.ImageMimeType;
                }
            }
            context.SaveChanges();
        }


        public Game DeleteGame(int gameId)
        {
            Game dbEntry = context.Games.Find(gameId);
            if (dbEntry != null)
            {
                context.Games.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveItem(IGoods item)
        {
            if (item.itemId == 0)
                context.items.Add(item);
            else
            {
                item dbEntry = context.items.Find(item.itemId);
                if (dbEntry != null)
                {
                    dbEntry.Name = item.Name;
                    dbEntry.Description = item.Description;
                    dbEntry.Price = item.Price;
                    dbEntry.Category = item.Category;
                    dbEntry.ImageData = item.ImageData;
                    dbEntry.ImageMimeType = item.ImageMimeType;
                }
            }
            context.SaveChanges();
        }

        public IGoods DeleteItem(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
