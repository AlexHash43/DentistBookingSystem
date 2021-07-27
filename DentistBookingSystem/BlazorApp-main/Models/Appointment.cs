using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Appointment
    {

        public int Id { get; set; }
        public DateTime DateStart { get; set; } = DateTime.Today;
        
        public DateTime TimeStart { get; set; } = DateTime.UtcNow;
        public DateTime DateStop { get; set; } = DateTime.Today;
        public DateTime TimeStop { get; set; } = DateTime.UtcNow;
        public DateTime TimeAndDateBooked { get; set; } = DateTime.Today;
#nullable enable
        public string? Reason { get; set; }
#nullable enable
        public string? Note { get; set; }
        public bool StatusBooked { get; set; }
#nullable enable
        public int? UserId { get; set; }
        
    }
}
