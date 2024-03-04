using EventSystemApi.Types;
using System.ComponentModel.DataAnnotations;

namespace EventSystemApi.Models
{
    public class Company: Person
    {

        public string JuridicalName { get; set; }
        public string RegisterCode { get; set; }

        public int ParticipantsAmount { get; set; } = 0;

        public PersonType PersonType = PersonType.Juridical;

        [StringLength(5000)]
        public new string? Info { get; set; }
    }
}
