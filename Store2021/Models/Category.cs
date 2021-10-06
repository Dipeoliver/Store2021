using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Categoria")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Responsável")]
        public string Owner { get; set; }

        public ICollection<Product> Products { get; set; } = new LinkedList<Product>();

        public Category() { }

        public Category(int id, string name, string owner)
        {
            Id = id;
            Name = name;
            Owner = owner;
        }
    }
}
