using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyLover.Domain.AggregateModels.EventAgg;
using AcademyLover.Domain.AggregateModels.EventAgg.Interfaces.Repositories;
using AcademyLover.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AcademyLover.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ValuesController : Controller
    {
        private IEventRepository _eventRepository;
        public ValuesController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var eventTest = new Event()
                {
                    Date = DateTime.Now,
                    Local = "ali",
                    Responsible = "cornildo",
                    Title = "tituloso",
                    Description = "asd",
                    Situation = EventSituation.OPEN,
                    State = "Rsds",

                };

                _eventRepository.Create(eventTest);
            }
            catch (Exception ex)
            {

                throw;
            }

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<object> Get(int id)
        {
            var result = _eventRepository.FindAll().ToList();

            return Ok(result.FirstOrDefault());
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
