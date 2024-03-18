using EventSystemApi.Types;

namespace EventSystemApi.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public EventStatus Status { get; set; }

        public string? Description { get; set; }

        public string? Place { get; set; }



        //public ICollection<Person> Participants { get; set; } = new List<Person>(); // Navigation property

        public ICollection<Company> Companies { get; set; } // Navigation property
        public ICollection<PrivatePerson> Persons { get; set; } // Navigation property

        //TODO: change list to optional,
        //add test for controllers methods
        public Event()
        {
            Companies = new List<Company>();
            Persons = new List<PrivatePerson>();
        }
    }
}
