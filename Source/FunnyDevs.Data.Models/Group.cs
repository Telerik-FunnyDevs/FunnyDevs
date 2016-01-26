using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyDevs.Data.Models
{
    public class Group
    {
        private ICollection<User> members;

        public Group()
        {
            this.members = new HashSet<User>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual User Admin { get; set; }
        public int AdminId { get; set; }

        public ICollection<User> Members
        {
            get { return this.members; }
            set { this.members = value; }
        }

    }
}
