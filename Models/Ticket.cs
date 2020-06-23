using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public enum Status { Open, Resolved, InProgress }
    public class Ticket
    {
        // Main Display info
        public int Id { get; set; }
        public string Priority { get; set; }
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
        public string Description { get; set; }
    }
}
