using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeStop { get; set; }
        public DateTime TimeAndDateBooked { get; set; } 
        public string Reason { get; set; }
        public string Note { get; set; }
        public bool StatusBooked { get; set; }
        public int UserId { get; set; }
    }
}
