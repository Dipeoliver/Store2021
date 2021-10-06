using Microsoft.AspNetCore.Mvc;
using Store2021.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Controllers
{
    public class CategorysController : Controller
    {
        private readonly CategoryServices _categoryServices;

        public CategorysController(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public async Task<IActionResult> Index()
        {
            // operação para chamar a lista FindAll
            var list = await _categoryServices.FindAllAsync(); // vai me retornar uma lista de sellers
            return View(list); // passa valores para a view
        }
    }
}
