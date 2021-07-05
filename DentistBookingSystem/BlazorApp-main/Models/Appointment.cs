using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; } = DateTime.Now;
        public DateTime TimeStop { get; set; } = DateTime.Now;
        public DateTime TimeAndDateBooked { get; set; } 
        public string? Reason { get; set; }
        public string? Note { get; set; }
        public bool? StatusBooked { get; set; }
        public int? UserId { get; set; }
        
    }
}
