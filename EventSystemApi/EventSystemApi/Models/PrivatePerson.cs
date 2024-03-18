using EventSystemApi.Types;
using System.ComponentModel.DataAnnotations;

namespace EventSystemApi.Models
{
    public class PrivatePerson: Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        //public string PersonType = Types.PersonType.Private.ToString();

        [StringLength(1500)]
        public new string? Info { get; set; }
    }
}
