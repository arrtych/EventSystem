using EventSystemApi.Application.Services;
using EventSystemApi.Domain.Models;
using EventSystemApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventSystemApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivatePersonsController : ControllerBase
    {
        private readonly PrivatePersonService _service;

        public PrivatePersonsController(PrivatePersonService service)
        {
            _service = service;
        }

        // GET: api/PrivatePersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrivatePerson>>> GetPersons()
        {
            var persons = await _service.GetAllPersons();
            return Ok(persons);
        }

        // GET: api/PrivatePersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PrivatePerson>> GetPrivatePerson(int id)
        {
            var person = await _service.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        // POST: api/PrivatePersons
        [HttpPost]
        public async Task<ActionResult<PrivatePerson>> CreatePrivatePerson(PrivatePerson person)
        {
            await _service.AddPerson(person);
            return CreatedAtAction(nameof(GetPrivatePerson), new { id = person.Id }, person);
        }


        // PUT: api/PrivatePersons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePrivatePerson(int id, PrivatePerson person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePerson(person);
            }
            catch (Exception)
            {
                if (!PrivatePersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // DELETE: api/PrivatePersons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrivatePerson(int id)
        {
            var person = await _service.GetPersonById(id);
            if (person == null)
            {
                return NotFound();
            }

            await _service.DeletePerson(id);

            return NoContent();
        }


        private bool PrivatePersonExists(int id)
        {
            return true;
        }

    }
}
