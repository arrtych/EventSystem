using EventSystemApi.Types;
using System.ComponentModel.DataAnnotations;

namespace EventSystemApi.Models
{
    public class PrivatePerson: Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public PersonType PersonType = PersonType.Private;

        [StringLength(1500)]
        public new string? Info { get; set; }
    }
}
