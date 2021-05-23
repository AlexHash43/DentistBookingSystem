using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class DeleteAppointmrntByIdRequest : IRequest<DeleteAppointmrntByIdResponse>
    {
        public int Id { get; set; }
    }
}
