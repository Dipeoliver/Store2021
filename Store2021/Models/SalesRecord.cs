using Store2021.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Venda")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "{0} required")]
        //[Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Preço Total")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }
        public int SellerId { get; set; }


        [Display(Name = "Observação")]
        public string Obs { get; set; }


        public ICollection<Product> Products { get; set; } = new List<Product>();
        public Client Client { get; set; }
        public int ClientId { get; set; }



        [Display(Name = "Pagamento")]
        public Payment Payment { get; set; }


        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, Seller seller, Client client, Payment payment)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Client = client;
            Payment = payment;
        }
    }
}
