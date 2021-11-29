using Core.Service;
using Microsoft.AspNetCore.Mvc;


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
        
        public IActionResult Home()
        {
            return View();
        }
    }
}
