using Microsoft.AspNetCore.Mvc;
using Store2021.Data;
using Store2021.Models;
using Store2021.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerService;

        public SellersController(SellerServices sellerServices)
        {
            _sellerService = sellerServices;
        }

        public async Task<IActionResult> Index()
        {
            // operação para chamar a lista FindAll
            var list = await _sellerService.FindAllAsync(); // vai me retornar uma lista de sellers
            return View(list); // passa valores para a view
        }


        // ação para adicionar item
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if (ModelState.IsValid)
            {
                await _sellerService.InsertAsync(seller);
                return RedirectToAction(nameof(Index));
            }
            return View(seller);
        }

    }
}
