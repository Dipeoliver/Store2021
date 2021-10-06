using Microsoft.AspNetCore.Mvc;
using Store2021.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientServices _clientServices;

        public ClientsController (ClientServices clientServices)
        {
            _clientServices = clientServices;
        }
        public async Task<IActionResult> Index()
        {
            // operação para chamar a lista FindAll
            var list = await _clientServices.FindAllAsync(); // vai me retornar uma lista de sellers
            return View(list); // passa valores para a view
        }
    }
}
