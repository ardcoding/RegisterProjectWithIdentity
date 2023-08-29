using BusinessServices.Layer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDb.Entity;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;

        public UsersController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            return await _userBusiness.GetUsers();
        }

        [HttpPost("UserRegister")]
        public IActionResult RegisterUser([FromBody] User user)
        {
            _userBusiness.AddUser(user);
            return Ok(user);
        }
    }
}
