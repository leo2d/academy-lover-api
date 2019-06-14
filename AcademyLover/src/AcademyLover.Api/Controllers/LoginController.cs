using AcademyLover.Application.Interfaces;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces;
using AcademyLover.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AcademyLover.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private IUserAppService _userService;

        public LoginController(IUserAppService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {
                var token = await _userService.DoLogin(loginViewModel);

                return Ok(new { token = token.Value });
            }

            return BadRequest();
        }

        [HttpPut]
        [Route("logout")]
        public async Task<IActionResult> LogOut([FromHeader]string token)
        {
            if (!string.IsNullOrEmpty(token))
            {
                await _userService.DoLogout(token);

                return Ok();
            }

            return BadRequest();
        }
    }
}
