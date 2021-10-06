using Microsoft.EntityFrameworkCore;
using Store2021.Data;
using Store2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Services
{
    public class ProductServices
    {
        // adicionar dependencia
        private readonly Store2021Context _context;
        public ProductServices(Store2021Context context)
        {
            _context = context;
        }

        // operacao retornar lista (SELECT) com todos vendedores
        public async Task<List<Product>> FindAllAsync()
        {
            return await _context.Product.ToListAsync();
        }
    }
}
