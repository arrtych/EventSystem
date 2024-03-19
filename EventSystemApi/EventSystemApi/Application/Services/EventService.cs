using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;

namespace EventSystemApi.Application.Service
{
    public class EventService
    {
        private readonly IRepository<Event> _eventRepository;

        public EventService(IRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<IEnumerable<Event>> GetAllEvents()
        {
            return await _eventRepository.GetAllAsync();
        }

        public async Task<Event> GetEventById(int id)
        {
            return await _eventRepository.GetByIdAsync(id);
        }

        public async Task AddEvent(Event e)
        {
            await _eventRepository.AddAsync(e);
        }

        public async Task UpdateEvent(Event e)
        {
            await _eventRepository.UpdateAsync(e);
        }

        public async Task DeleteEvent(int id)
        {
            await _eventRepository.DeleteAsync(id);
        }
    }
}
