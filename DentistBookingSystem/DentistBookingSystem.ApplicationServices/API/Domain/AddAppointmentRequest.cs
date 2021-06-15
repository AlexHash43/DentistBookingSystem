using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class AddAppointmentRequest : IRequest<AddAppointmentResponse>
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }
        public DateTime TimeAndDateBooked { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }
        public int UserId { get; set; }
    }
}
