using AcademyLover.Application.Interfaces;
using AcademyLover.Domain.AggregateModels.UserAgg.Interfaces;
using AcademyLover.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Examples;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AcademyLover.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserAppService _userService;

        public UserController(IUserAppService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Teste() { return Ok("ok"); }

        /// <summary>
        /// Create a User
        /// </summary>
        /// <param name="User"></param>
        /// <response code="200">User created</response>
        [HttpPost]
        [AllowAnonymous]
        [Consumes("application/json")]
        //[SwaggerRequestExample(typeof(HouseCreate), typeof(HouseCreateExample))]
        //[SwaggerResponse((int)HttpStatusCode.OK)]
        public async Task<IActionResult> Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.CreateNewUser(userViewModel);
                return Ok("User created");
            }

            return BadRequest("Os dados passados são inválidos ou estão incompletos.");
        }

    }
}
