using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
     public interface IItem
    {
         int Id { get; set; }
         string Name { get; set; }
         int Price { get; set; }
    }
    public abstract class BaseGood : IItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0,999,ErrorMessage ="Price must be established explicitly!")]        
        public int Price { get; set; }


        public string Description { get; set; }

        public bool IsFree { get; set; }


    }

class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
   

    public class Game : BaseGood
    { }

    

}
