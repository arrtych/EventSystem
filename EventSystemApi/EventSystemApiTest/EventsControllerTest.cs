using AutoFixture;
using EventSystemApi.Application.Services;
using EventSystemApi.Domain.Interfaces;
using EventSystemApi.Domain.Models;
using EventSystemApi.Presentation.Controllers;
using Moq;

namespace EventSystemApiTest
{
    public class EventsControllerTest
    {

        private Mock<IRepository<Event>> _repositoryMock;
        private EventService _eventService;
        private Fixture _fixture;
        private EventsController _controller;

        public EventsControllerTest()
        {
            _fixture = new Fixture();
            _repositoryMock = new Mock<IRepository<Event>>();
            _eventService = new EventService(_repositoryMock.Object);
            _controller = new EventsController(_eventService);


        }

        [Fact]
        public async Task Test1Async()
        {
            var eventList = _fixture.CreateMany<Event>(3).ToList();
            _repositoryMock.Setup(repo => repo.GetAllAsync()).Returns(Task.FromResult<IEnumerable<Event>>(eventList));
            var result = await _controller.GetEvents();
            //var obj = result as ObjectResult;

            Console.WriteLine(result);
        }
    }
}