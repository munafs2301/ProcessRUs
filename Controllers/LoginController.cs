using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessRUs.DTOs;
using ProcessRUs.Interfaces;

namespace ProcessRUs.Controllers
{

    [Route("api/v1/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService iuserService)
        {
            _userService = iuserService;
        }

        [HttpPost]
        public ActionResult<LoginResponse> Login(UserInfo userInfo)
        {
            var loginResponse = _userService.Login(userInfo);
            if (loginResponse != null)
            {
                return Ok(loginResponse);
            }

            return NotFound($"{userInfo.Email} is not registered in our application");
        }
    }
}