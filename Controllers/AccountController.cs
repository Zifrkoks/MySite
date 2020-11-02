using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;
using MySite.Domain;
using MySite.Domain.Repository;

namespace MySite.Controllers
{
    public class AccountController : Controller
    {
        DataManager db;
        public AccountController(DataManager context)
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
                    db.Clients.AddClient(client);
                    return View();
        }
        /*public IActionResult Auth()
        {
            return View();
        }*/
    }
}
