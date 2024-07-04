using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string? userFirstName { get; set; }
        public string? userLastName { get; set; }
        public string? userEmail { get; set; }
        public Department department { get; set; }

        public Role role { get; set; }
        public string? userPassword { get; set; }

    }
}
