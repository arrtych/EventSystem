using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;
using EventSystemApi.Infrastructure.Data;
using EventSystemApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EventSystemApi.Infrastructure.Repositories
{
    public class PrivatePersonRepository : IRepository<PrivatePerson>
    {
        private readonly EventSystemDbContex _context;

        public PrivatePersonRepository(EventSystemDbContex context)
        {
            _context = context;
        }

        public async Task AddAsync(PrivatePerson entity)
        {
            await _context.PrivatePersons.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.PrivatePersons.FindAsync(id);
            _context.PrivatePersons.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PrivatePerson>> GetAllAsync()
        {
            return await _context.PrivatePersons.ToListAsync();
        }

        public async Task<PrivatePerson> GetByIdAsync(int id)
        {
            return await _context.PrivatePersons.FindAsync(id);
        }

        public async Task UpdateAsync(PrivatePerson entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
