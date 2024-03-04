using EventSystemApi.Types;

namespace EventSystemApi.Models
{
    public class Person
    {

        public int Id { get; set; }

        public PaymentType PaymentType { get; set; }

        public PersonType PersonType { get; protected set; }

        public string? Info { get; set; }



    }
}
