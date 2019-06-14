using AcademyLover.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AcademyLover.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class EventsController : Controller
    {
        private readonly IEventAppService _eventService;
        
        public EventsController(IEventAppService eventAppService)
        {
            _eventService = eventAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {


            return Ok();
        }
    }
}
