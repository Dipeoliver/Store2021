using Microsoft.EntityFrameworkCore;
using Store2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Data
{
    public class Store2021Context : DbContext
    {
        public Store2021Context(DbContextOptions<Store2021Context> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
