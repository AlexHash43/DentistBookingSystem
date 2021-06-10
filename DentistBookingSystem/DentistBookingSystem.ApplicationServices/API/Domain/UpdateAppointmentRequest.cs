using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class UpdateAppointmentRequest : IRequest<UpdateAppointmentResponse>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeStop { get; set; }
        public DateTime TimeAndDateBooked { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }
    }
}
