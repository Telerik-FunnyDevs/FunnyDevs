namespace FunnyDevs.Services.Contracts
{
    using Data.Models;
    using System;
    using System.Linq;

    public interface IEventService
    {
        IQueryable<Event> AllEvents();

        Event EventById(int id);

        Event CreateEvent(string tittle, string description, string location, DateTime date);

        int EventCount();
    }
}
