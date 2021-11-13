using Microsoft.AspNetCore.Mvc;
using Stock_v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Controllers
{
    public class StocksController : Controller
    {
        public IActionResult Index()
        {
            var stockScraper = new StockScrapper();
            var stocks = stockScraper.GetStocks();
            return View(stocks);
        }
    }
}
