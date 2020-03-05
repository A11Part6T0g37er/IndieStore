using System;
using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
     public interface IPerson
    {
         int Id { get; set; }
         string Name { get; set; }
    }
    public abstract class BaseUser : IPerson
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
       
    }

   

    public class Customer : BaseUser
    { }

    public class Admin : BaseUser
    { }

    public class MAnager : BaseUser
    { }

}
