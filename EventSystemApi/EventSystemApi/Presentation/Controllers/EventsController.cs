using EventSystemApi.Application.Service;
using EventSystemApi.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventSystemApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }

        // GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var events = await _eventService.GetAllEvents();
            return Ok(events);
        }

        // GET: api/events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var e = await _eventService.GetEventById(id);

            if (e == null)
            {
                return NotFound();
            }

            return e;
        }


        // POST: api/events
        [HttpPost]
        public async Task<ActionResult<Event>> CreateEvent(Event e)
        {
            await _eventService.AddEvent(e);
            return CreatedAtAction(nameof(GetEvent), new { id = e.Id }, e);
        }


        // PUT: api/event/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, Event e)
        {
            if (id != e.Id)
            {
                return BadRequest();
            }

            try
            {
                await _eventService.UpdateEvent(e);
            }
            catch (Exception)
            {
                if (!EventExists(id))
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


        // DELETE: api/events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var e = await _eventService.GetEventById(id);
            if (e == null)
            {
                return NotFound();
            }

            await _eventService.DeleteEvent(id);

            return NoContent();
        }



        private bool EventExists(int id)
        {
            // For example, check if the event with the given id exists in the database
            return true;
        }
    }
}
