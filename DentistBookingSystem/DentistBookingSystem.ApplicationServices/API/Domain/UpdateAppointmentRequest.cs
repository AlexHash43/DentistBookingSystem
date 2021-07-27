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
        public DateTime DateStart { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime DateStop { get; set; }
        public DateTime TimeStop { get; set; }
        public DateTime TimeAndDateBooked { get; set; }
#nullable enable
        public string? Reason { get; set; }
#nullable enable
        public string? Note { get; set; }
#nullable enable
        public int? UserId { get; set; }
    }
}
