using EventSystemApi.Domain.Models;
using EventSystemApi.Models;
using EventSystemApi.Types;
using Microsoft.EntityFrameworkCore;

namespace EventSystemApi.Infrastructure.Data
{
    public class EventSystemDbContex : DbContext
    {

        public EventSystemDbContex(DbContextOptions<EventSystemDbContex> options) : base(options)
        {

        }
        public DbSet<Event> Events { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<PrivatePerson> PrivatePersons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasMany(e => e.Companies)
                .WithMany(c => c.Events)
                .UsingEntity(j => j.ToTable("EventCompany"));

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Persons)
                .WithMany(p => p.Events)
                .UsingEntity(j => j.ToTable("EventPerson"));
        }


    }
}
