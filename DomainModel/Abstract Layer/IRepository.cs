using System;
using System.Collections.Generic;
using System.Text;
using DomainModel.Models;

namespace DomainModel.Abstract_Layer
{
  public  interface IRepository<T> where T : IGoods
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
