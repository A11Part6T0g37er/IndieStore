using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    /// <summary>
    /// Generic repository of items
    /// </summary>
    /// <typeparam name="T">T must implement IGoods interface</typeparam>
    public interface IItemsRepository<T> where T : IGoods
    {
        IEnumerable<T> Items { get; }
        void SaveItem(T item);
        T DeleteItem(int itemId);
    }
}
