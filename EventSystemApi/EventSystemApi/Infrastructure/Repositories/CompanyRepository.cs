using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;
using EventSystemApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EventSystemApi.Infrastructure.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly EventSystemDbContex _context;



        //private DbSet<T> GetDbSetByPerson<T>(Person person) where T : Person
        //{
        //    if (typeof(T) == typeof(PrivatePerson) || typeof(T) == typeof(Company))
        //    {
        //        return _context.Set<T>();
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Invalid type of person");
        //    }
        //}

        public CompanyRepository(EventSystemDbContex context)
        {
            _context = context;
        }

        public async Task AddAsync(Company entity)
        {
            await _context.Companies.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public async Task UpdateAsync(Company entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
