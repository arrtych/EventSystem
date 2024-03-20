using EventSystemApi.Application.Services;
using EventSystemApi.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventSystemApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly CompanyService _service;

        public CompaniesController(CompanyService service)
        {
            _service = service;
        }

        // GET: api/companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            var companies = await _service.GetAllCompanies();
            return Ok(companies);
        }

        // GET: api/company/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _service.GetCompanyById(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }


        // POST: api/company
        [HttpPost]
        public async Task<ActionResult<Company>> CreateCompany(Company c)
        {
            await _service.AddCompany(c);
            return CreatedAtAction(nameof(GetCompany), new { id = c.Id }, c);
        }


        // PUT: api/company/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany(int id, Company c)
        {
            if (id != c.Id)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCompany(c);
            }
            catch (Exception)
            {
                if (!CompanyExists(id))
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

        // DELETE: api/company/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var c = await _service.GetCompanyById(id);
            if (c == null)
            {
                return NotFound();
            }

            await _service.DeleteCompany(id);

            return NoContent();
        }


        private bool CompanyExists(int id)
        {
            // For example, check if the event with the given id exists in the database
            return true;
        }

    }
}
