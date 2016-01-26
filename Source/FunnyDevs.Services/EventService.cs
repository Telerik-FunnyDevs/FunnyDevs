using FunnyDevs.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunnyDevs.Data.Models;
using Exam.Data.Repositories;

namespace FunnyDevs.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository<Event> events;

        public EventService(IRepository<Event> events)
        {
            this.events = events;
        }

        public IQueryable<Event> AllEvents()
        {
            return events.All();
        }

        public Event CreateEvent(string tittle, string description, string location, DateTime date)
        {
            var eventToAdd = new Event
            {
                Tittle = tittle,
                Description = description,
                Location = location,
                Date = date
            };

            this.events.Add(eventToAdd);
            this.events.SaveChanges();

            return eventToAdd;
        }

        public Event EventById(int id)
        {
            return this.events.GetById(id);
        }

        public int EventCount()
        {
            return this.events.All().Count();
        }
    }
}
