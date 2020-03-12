using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DomainModel
{
    public abstract class BaseGood : IGoods
    {
       
      
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0.01,999,ErrorMessage ="Price must be established explicitly!")]        
        public decimal Price { get; set; }


        public string Description { get; set; }
        
        //TODO
        [Required]
        public bool IsFree { get; set; }
       
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }

        public List<Category> Categories { get; set; }

    }

public class Category : ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
   

    public class Game : BaseGood
    { }

    

}
