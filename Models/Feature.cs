using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        public string? bugSummery { get; set; }
        public string? Description { get; set; }
        public Severity severity { get; set; }
        public Priority priority { get; set; }
    }
}
