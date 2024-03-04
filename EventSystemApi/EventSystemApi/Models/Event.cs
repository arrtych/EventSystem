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




    }
}
