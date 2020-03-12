using System.Collections.Generic;

namespace DomainModel
{
    public interface IGoods
    {
         int Id { get; set; }
         string Name { get; set; }
         decimal Price { get; set; }
         string Description { get; set; }
         bool IsFree { get; set; }
         List<ICategory> Categories { get; set; }
    }

    

}
