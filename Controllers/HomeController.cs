using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        DataContext db;
        
        public HomeController(DataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View(db.Products.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Products");
            ViewBag.ProductId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            try
            {
                db.SaveChanges();
                return "Спасибо, " + order.ClientName + ", за покупку!";
            }
            catch(Exception ex){
                Console.WriteLine(ex.ToString());
                return "какой то пиздец серверу: " + ex.ToString();
            };
        }
        public IActionResult Registration()
        {

            return View();
        }
        public IActionResult Auth()
        {
            return View();
        }
    }
}
