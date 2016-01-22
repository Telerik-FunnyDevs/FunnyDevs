namespace FunnyDevs.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common;
    using System;

    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(MessageConstants.ContentMinLength)]
        [MaxLength(MessageConstants.ContentMaxLength)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
