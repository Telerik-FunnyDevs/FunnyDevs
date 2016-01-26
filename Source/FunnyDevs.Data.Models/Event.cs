using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDevs.Data.Models
{
    public class Event
    {
        public string Tittle { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        public string GPSLong { get; set; }

        public string GPSLan { get; set; }

        public bool Public { get; set; }

        public virtual User Creator { get; set; }

    }
}
