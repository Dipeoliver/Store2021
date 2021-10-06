using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Código")]
        public string Code { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        [Display(Name = "Produto")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Cor")]
        public string Color { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Tamanho")]
        public string Size { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Custo")]
        public double Price { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Preço Venda")]
        public double SalesPrice { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data Compra")]
        public DateTime Date { get; set; }

        public SalesRecord SalesRecord { get; set; }
        public int SalesRecordId { get; set; }


        public Category Category { get; set; }

        public Product() { }

        public Product(int id, string code, string name, string color, string size, double price, double salesPrice, DateTime date, SalesRecord salesRecord)
        {
            Id = id;
            Code = code;
            Name = name;
            Color = color;
            Size = size;
            Price = price;
            SalesPrice = salesPrice;
            Date = date;
            SalesRecord = salesRecord;
        }
    }
}
