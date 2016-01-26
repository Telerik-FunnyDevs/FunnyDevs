namespace FunnyDevs.Web.Events
{
    using FunnyDevs.Data;
    using FunnyDevs.Data.Models;
    using Ninject;
    using Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class All : System.Web.UI.Page
    {

        [Inject]
        public IEventService EventService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Event> GridViewAll_GetData()
        {
            var events = this.EventService.AllEvents();
            return events;
        }
    }
}