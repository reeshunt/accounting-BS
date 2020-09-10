using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountingWeb.Models;
using AccountingWeb.AppDbContext;

namespace AccountingWeb.Controllers
{
    public class AppController : Controller
    {
        
        public IActionResult Index()
        {
            //List<firm> firmList = new List<firm>();
            //firmList = (from i in _db.firm select i).ToList();
            //return View(firmList);
            return View();
        }
        public IActionResult Login() {
            return View();
        }
        public IActionResult FlexReport() {
            return View();
        }
        
    }
}