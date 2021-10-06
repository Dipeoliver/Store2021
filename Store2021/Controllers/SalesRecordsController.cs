using Microsoft.AspNetCore.Mvc;
using Store2021.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordServices _salesRecordService;
        private readonly SellerServices _sellerServices;
        private readonly ClientServices _clientServices;

        public SalesRecordsController(SalesRecordServices salesRecordService, SellerServices sellerServices, ClientServices clientServices)
        {
            _salesRecordService = salesRecordService;
            _sellerServices = sellerServices;
            _clientServices = clientServices;
        }

        public async Task<IActionResult> Index()
        {  

            // operação para chamar a lista FindAll
            var list = await _salesRecordService.FindAllAsync(); // vai me retornar uma lista de sellers
            return View(list); // passa valores para a view
        }       
    }
}
