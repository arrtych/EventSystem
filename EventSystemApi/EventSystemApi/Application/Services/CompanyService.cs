using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;
using EventSystemApi.Models;

namespace EventSystemApi.Application.Services
{
    public class CompanyService
    {
        private readonly IRepository<Company> _repository;

        public CompanyService(IRepository<Company> companyRepository)
        {
            _repository = companyRepository;
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddCompany(Company e)
        {
            await _repository.AddAsync(e);
        }

        public async Task UpdateCompany(Company e)
        {
            await _repository.UpdateAsync(e);
        }

        public async Task DeleteCompany(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
