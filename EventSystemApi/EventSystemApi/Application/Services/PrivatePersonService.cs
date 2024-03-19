using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;
using EventSystemApi.Infrastructure.Repository;
using EventSystemApi.Models;

namespace EventSystemApi.Application.Services
{
    public class PrivatePersonService
    {
        private readonly IRepository<PrivatePerson> _repository;

        public PrivatePersonService(IRepository<PrivatePerson> personRepository)
        {
            _repository = personRepository;
        }

        public async Task<IEnumerable<PrivatePerson>> GetAllPersons()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<PrivatePerson> GetPersonById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddPerson(PrivatePerson e)
        {
            await _repository.AddAsync(e);
        }

        public async Task UpdatePerson(PrivatePerson e)
        {
            await _repository.UpdateAsync(e);
        }

        public async Task DeletePerson(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
