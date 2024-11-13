using System;
using System.ComponentModel.DataAnnotations;

namespace st10230365Poe.Models
{
    public class UserInput
    {
        // Primary key
        [Key]
        public string RowKey { get; set; } = Guid.NewGuid().ToString();

        // Customer Details
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        // Additional fields for other user data can be added here
        // For example:
        // public string PhoneNumber { get; set; }
        // public string Notes { get; set; }
    }
}
