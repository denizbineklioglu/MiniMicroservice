using Demo.CustomerAPI.Model.dto;
using Demo.CustomerAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(UserRegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                await _authService.Register(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(UserLoginRequest model)
        {
            var result = _authService.Login(model).Result;
            if (result)
            {
                return Ok("Giriş Yapıldı");
            }
            return BadRequest();
        }

    }
}
