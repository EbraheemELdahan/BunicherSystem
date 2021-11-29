using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Admin.Controllers
{
    public class Order : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
