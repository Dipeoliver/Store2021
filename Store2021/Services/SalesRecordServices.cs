using Microsoft.EntityFrameworkCore;
using Store2021.Data;
using Store2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Services
{
    public class SalesRecordServices
    {
        // adicionar dependencia
        private readonly Store2021Context _context;
        public SalesRecordServices(Store2021Context context)
        {
            _context = context;
        }

        // operacao retornar lista (SELECT) com todos vendedores
        public async Task<List<SalesRecord>> FindAllAsync()
        {
            return await _context.SalesRecord.Include(obj => obj.Seller).Include(obj => obj.Client).ToListAsync();
        }

        // Busca no banco de dados atraves de um Id;
        public async Task<SalesRecord> FindByIdAsync(int id)
        {
            return await _context.SalesRecord.Include(obj => obj.Seller).Include(obj => obj.Client).FirstOrDefaultAsync(obj => obj.Id == id);
        }
    }
}
