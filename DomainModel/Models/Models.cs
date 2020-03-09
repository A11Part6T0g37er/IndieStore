using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DomainModel
{
    public abstract class BaseGood : IItem
    {
       
        [HiddenInput(DisplayValue = false)]
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

    }

class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
   

    public class Game : BaseGood
    { }

    

}
