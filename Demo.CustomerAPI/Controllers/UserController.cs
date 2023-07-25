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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsers();
            if (users.Count() > 0)
            {
                return Ok(users);
            }
            return BadRequest();
        }

        [HttpPost("[action]/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            if (id > 0)
            {
                var user = await _userService.GetById(id);
                return Ok(user);
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUser(UserAddRequest model)
        {
            if (ModelState.IsValid)
            {
                await _userService.CreateUser(model);
                return Ok("Kullanıcı Başarıyla Eklenmiştir");
            }
            return BadRequest();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id > 0)
            {
                await _userService.Delete(id);
                return Ok($"{id} numaralı kullanıcı silinmiştir.");
            }
            return BadRequest("Silinemedi");
        }





    }
}
