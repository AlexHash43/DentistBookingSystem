using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class GetAppointmentByIdRequest : IRequest<GetAppointmentByIdResponse>
    {
        public int Id { get; set; }
    }
}
