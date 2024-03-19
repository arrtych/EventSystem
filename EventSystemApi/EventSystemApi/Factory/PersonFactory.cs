using EventSystemApi.Domain.Models;
using EventSystemApi.Models;

namespace EventSystemApi.Factory
{
    public static class PersonFactory
    {
        public static PrivatePerson CreatePrivatePerson()
        {
            return new PrivatePerson();
        }

        public static Company CreateCompany()
        {
            return new Company();
        }
    }
}
