using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult AddEdit()
        {
            return View();
        }
        public IActionResult AddEditRecipt()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
    }
}
