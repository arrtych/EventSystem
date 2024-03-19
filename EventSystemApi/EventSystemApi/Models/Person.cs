using EventSystemApi.Types;

namespace EventSystemApi.Models
{
    public abstract class Person
    {

        public int Id { get; set; }

        public PaymentType PaymentType { get; set; }

        //public string PersonType { get; protected set; }

        public string? Info { get; set; }


        public ICollection<Event> Events { get; set; } // Navigation property

        public Person()
        {
            Events = new List<Event>();
        }


    }
}
