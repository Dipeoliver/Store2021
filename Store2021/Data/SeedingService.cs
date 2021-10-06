using Store2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Store2021.Models.Enums;
namespace Store2021.Data
{
    public class SeedingService
    {

        private Store2021Context _context;

        public SeedingService(Store2021Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Category.Any() || _context.Product.Any() || _context.SalesRecord.Any() || _context.Seller.Any())
            {
                return; // DB has been seeded
            }
            Seller s1 = new Seller(1, "Claudia", "claudia@gmail.com");

            Category c1 = new Category(1, "Biquine", "Claudia");
            Category c2 = new Category(2, "Chapeu", "Claudia");
            Category c3 = new Category(3, "Vestidos", "Nice");

            Client cl = new Client(1, "337816098", "Diego Oliveira", "12991797413", "Antenor Vargas", "157");

            SalesRecord sr1 = new SalesRecord(1, new DateTime(1998, 4, 21), 250.00, s1,null,Payment.Dinheiro);

            Product p1 = new Product(1, "12345678", "Biquine de Alça", "Azul", "GG", 100.00, 250.00, new DateTime(2021, 11, 01), sr1);

            _context.Category.AddRange(c1, c2, c3);
            _context.Seller.AddRange(s1);
            _context.SalesRecord.AddRange(sr1);
            _context.Product.AddRange(p1);
            _context.Client.AddRange(cl);

            _context.SaveChanges();
        }


    }
}
