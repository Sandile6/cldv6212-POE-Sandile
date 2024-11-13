using System.ComponentModel.DataAnnotations;

namespace st10230365Poe.Models
{
    public class Customer
    {
        [Key]  // Specify RowKey as the primary key
        public string RowKey { get; set; } // Use as primary key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
