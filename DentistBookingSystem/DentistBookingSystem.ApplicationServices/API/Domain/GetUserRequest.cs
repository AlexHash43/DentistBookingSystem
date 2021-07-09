using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class GetUserRequest : IRequest<GetUserResponse> 
    {
#nullable enable
        public string? Name { get; set; } 
        public string? Surname { get; set; } 
        public string? BirthDate { get; set; } 

    }
}
