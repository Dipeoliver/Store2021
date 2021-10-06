using Microsoft.AspNetCore.Mvc;
using Store2021.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductServices _productService;
        private readonly SalesRecordServices _salesRecordServices;

        public ProductsController(ProductServices productServices, SalesRecordServices salesRecordServices)
        {
            _productService = productServices;
            _salesRecordServices = salesRecordServices;
        }
        public async Task<IActionResult> Index()
        {
            // operação para chamar a lista FindAll
            var list = await _productService.FindAllAsync(); // vai me retornar uma lista de sellers
            return View(list); // passa valores para a view
        }
    }
}
