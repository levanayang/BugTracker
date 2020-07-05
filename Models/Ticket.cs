using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public enum Status { 
        [Display(Name = "Open")]
        Open, 
        [Display(Name = "In Progress")]
        InProgress,
        [Display(Name = "Resolved")]
        Resolved
    }
    public enum Priority
    {
        [Display(Name = "Low")]
        Low,
        [Display(Name = "Medium")]
        Medium,
        [Display(Name = "High")]
        High
    }

    public class Ticket
    {
        // Main Display info
        public int Id { get; set; }
        [Display(Name = "Priority")]
        public Priority TicketPriority { get; set; }
        [Required]
        public string Title { get; set; }
        [Display(Name = "Status")]
        public Status TicketStatus { get; set; }

        // Date info
        [Display(Name = "Opened")]
        [DataType(DataType.Date)]
        public DateTime OpenDate { get; set; }
        [Display(Name = "Due")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        [Display(Name = "Closed")]
        [DataType(DataType.Date)]
        public DateTime CloseDate { get; set; }

        // Details
        public string Author { get; set; }
        [MaxLength(8000)]
        public string Description { get; set; }
    }
}
