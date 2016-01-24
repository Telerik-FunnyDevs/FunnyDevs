namespace FunnyDevs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class Group
    {
        private ICollection<User> users;
        private ICollection<Comment> comments;

        public Group()
        {
            this.users = new HashSet<User>();
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(GroupConstants.TitleMinLength)]
        [MaxLength(GroupConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(GroupConstants.DescriptionMinLength)]
        [MaxLength(GroupConstants.DescriptionMaxLength)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public virtual User Admin { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
