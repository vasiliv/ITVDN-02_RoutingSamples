using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _03_Literal.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult List()
        {
            string[] data = {"List1", "List2", "List3"};
            return View(data);
        }
    }
}
