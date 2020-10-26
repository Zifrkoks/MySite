using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;

namespace MySite.Controllers
{
    public class AccountController : Controller
    {
        DataContext db;
        public AccountController(DataContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Success(Client client)
        {

            if (client != null)
            {
                try
                {
                    db.Clients.Add(client);
                    db.SaveChanges();
                    return View();
                }
                catch
                {
                    return RedirectToAction("Registration");
                }
            }
            else return RedirectToAction("Registration");
        }
        /*public IActionResult Auth()
        {
            return View();
        }*/
    }
}
