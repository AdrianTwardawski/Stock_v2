using Microsoft.AspNetCore.Mvc;
using Stock_v2.Data;
using Stock_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Controllers
{
    public class StocksController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StocksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var stockScraper = new StockScrapper();
            var stocks = stockScraper.GetStocks();
            var stockList = new Stock();
            foreach (var stock in stocks)
            {
                stockList.Walor = stock.Walor;
                stockList.Kurs = stock.Kurs;  
                stockList.Id = stockList.Id;
                          
            _db.Stocks.Add(stockList);
            _db.SaveChanges();
            }

            return View(stocks);
        }

    }

}
