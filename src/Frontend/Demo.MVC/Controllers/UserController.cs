using Demo.MVC.Models.User;
using Demo.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                await _userService.Register(model);
                return RedirectToAction("Login","User");
            }
            return View();
        }

        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                await _userService.Login(model);
                return RedirectToAction("GetProducts", "Product");
            }
            return View();
        }

    }
}
