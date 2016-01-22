namespace FunnyDevs.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(CommentConstants.ContentMinLength)]
        [MaxLength(CommentConstants.ContentMaxLength)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

    }
}
