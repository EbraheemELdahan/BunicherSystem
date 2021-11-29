using Core.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IServiceWrapper _service;

        public UserController(IServiceWrapper service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
          var Users=  _service.UserService.GetAll();

            return View(Users);
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
