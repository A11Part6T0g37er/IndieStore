using System;
using System.Collections.Generic;
using System.Text;
using DomainModel.Abstract_Layer;
namespace DomainModel
{
   
    public interface IGamesRepository
    {
        IEnumerable<Game> GetGamesList();
        void SaveGame(Game item);
        void DeleteGame(int itemId);
        
    }
}
