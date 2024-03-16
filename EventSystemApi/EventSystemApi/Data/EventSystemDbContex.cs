using EventSystemApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EventSystemApi.Data
{
    public class EventSystemDbContex: DbContext
    {

        public EventSystemDbContex(DbContextOptions<EventSystemDbContex> options) : base(options)
        {

        }
        public DbSet<Event> Events { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<PrivatePerson> Persons { get; set; }




    }
}
