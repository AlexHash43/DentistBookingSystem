using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }
        public DateTime TimeAndDateBooked { get; set; } = DateTime.UtcNow;
        public string Reason { get; set; }
        public string Note { get; set; }
        public int UserId { get; set; }

    }
}
