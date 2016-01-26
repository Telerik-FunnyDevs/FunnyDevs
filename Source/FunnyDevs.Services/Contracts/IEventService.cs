namespace FunnyDevs.Services.Contracts
{
    using Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEventService
    {
        IQueryable<Event> AllEvents();

        Event EventById(int id);

        Event CreateEvent(string tittle, string description, string location, DateTime date);

        int EventCount();
    }
}
