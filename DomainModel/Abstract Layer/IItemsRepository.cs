using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public interface IItemsRepository
    {
        IEnumerable<Item> Items { get; }
        void SaveItem(Item item);
        Item DeleteItem(int itemId);
    }
}
