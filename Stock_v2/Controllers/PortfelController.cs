using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Stock_v2.Data;
using Stock_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_v2.Controllers
{
    public class PortfelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PortfelController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Portfel> objList = _db.Portfels;
            foreach (var obj in objList)
            {
                //Stock k  = _db.Stocks.FirstOrDefault(u => u.Id == obj.WalorId);               
                //obj.Zysk = (obj.Kurs- obj.CenaZakupu) * obj.LiczbaAkcji;
            }
            return View(objList);
        }

        //GET - Create
        [HttpGet]
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> TypeDropDown = _db.Stocks.Select(i => new SelectListItem
            {
                Text = i.Walor,
                Value = i.Id.ToString()
            });
            ViewBag.TypeDropDown = TypeDropDown;
            return View();
        }

        //POST - Create
        [HttpPost]
        public IActionResult CreatePost(Portfel portfel)
        {
            var stockList = new Stock();
            portfel.Zysk = (portfel.Kurs - portfel.CenaZakupu) * portfel.LiczbaAkcji;
            portfel.Kurs = stockList.Kurs;
            if (ModelState.IsValid)
            {
                
                _db.Add(portfel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(portfel);
        }
    }
}
