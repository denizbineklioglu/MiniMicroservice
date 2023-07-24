using Demo.CustomerAPI.Model.dto;
using Demo.CustomerAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserRegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                await _userService.Register(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}
