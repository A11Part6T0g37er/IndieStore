using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DomainModel
{
    public abstract class BaseGood : IGoods
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0.01, 999, ErrorMessage = "Price must be established explicitly!")]
        public decimal Price { get; set; }


        public string Description { get; set; }

        //TODO Logic implementing furthemore
        [Required]
        public bool IsFree { get; set; } = false;

        //  public byte[] ImageData { get; set; }
        //   public string ImageMimeType { get; set; }

        //  public List<Category> Categories { get; set; }
        public CategoryList Categories { get; set; }
    }

    public class Category : ICategory
    {
        public int Id { get;  set; } 
        public string Name { get; set; }

    }
    public class CategoryList : List<Category>
    {
        public new void Add(Category m)
        {
            base.Add(m);
            m.Id = this.IndexOf(m);
        }
        public new void Remove(Category m)
        {
            base.Remove(m);
            m.Id = -1;
            Reseed();
        }
        public new void RemoveAt(int index)
        {
            Category m = this[index];
            this.Remove(m);
        }
        public new int RemoveAll(Predicate<Category> match)
        {
            List<Category> removing = new List<Category>();
            foreach (Category m in this)
                if (match(m))
                    removing.Add(m);

            foreach (Category m in removing)
            {
                this.Remove(m);
            }
            return removing.Count;
        }
        public new void RemoveRange(int index, int count)
        {
            for (int i = index; i < count; i++)
            {
                Category m = this[i];
                this.Remove(m);
            }
        }
        public new Category this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                base[index] = value;
                Reseed();
            }
        }

        private void Reseed()
        {
            foreach (Category x in this)
            {
                x.Id = this.IndexOf(x);
            }
        }
    }



}
