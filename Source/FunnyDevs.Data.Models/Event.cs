namespace FunnyDevs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common;
    
    public class Event
    {
        private ICollection<User> users;

        public Event()
        {
            this.users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(EventConstants.DescriptionMinLength)]
        [MaxLength(EventConstants.DescriptionMaxLength)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime EventDate { get; set; }

        public string UserId { get; set; }

        public virtual User Creator { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }
    }
}
