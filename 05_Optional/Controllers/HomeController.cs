using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _05_Optional.Controllers
{
    public class HomeController : Controller
    {
        static private Dictionary<int, string> products = new Dictionary<int, string>();
        public HomeController()
        {
            products.Add(1, "Laptop");
            products.Add(2, "Desctop");
            products.Add(3, "TV");
        }
        public IActionResult Details(int? Id)
        {
            return View(products[(int)Id] as object);
        }
    }
}
