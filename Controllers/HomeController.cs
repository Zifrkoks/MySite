using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;
using MySite.Domain;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        DataManager db;
        
        public HomeController(DataManager context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View(db.Products.GetAllProducts());
        }
        [HttpGet]
        public IActionResult Buy(int? id, Client client)
        {
            if (id == null) return RedirectToAction("Products");
            ViewBag.ProductId = id;
            ViewBag.client = client;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            db.Orders.AddOrder(order);
            return View();
        }
        
    }
}
