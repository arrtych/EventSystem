using EventSystemApi.Data;
using EventSystemApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EventSystemApi.Repository
{
    public class EventRepository : IRepository<Event>
    {

        private readonly EventSystemDbContex _context;

        public EventRepository(EventSystemDbContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> GetByIdAsync(int id)
        {
            return await _context.Events.FindAsync(id);
        }


        public async Task AddAsync(Event entity)
        {
            await _context.Events.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Events.FindAsync(id);
            _context.Events.Remove(entity);
            await _context.SaveChangesAsync();
        }



        public async Task UpdateAsync(Event entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
