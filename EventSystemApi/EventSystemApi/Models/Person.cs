using EventSystemApi.Types;

namespace EventSystemApi.Models
{
    public abstract class Person
    {

        public int Id { get; set; }

        public PaymentType PaymentType { get; set; }

        //public string PersonType { get; protected set; }

        public string? Info { get; set; }

        //public int EventId { get; set; } // Foreign key for Event
        //public Event Event { get; set; } // Navigation property

        public ICollection<Event> Events { get; set; } // Navigation property

        public Person()
        {
            Events = new List<Event>();
        }


    }
}
