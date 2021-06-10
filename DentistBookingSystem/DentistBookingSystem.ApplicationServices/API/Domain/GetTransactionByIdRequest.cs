using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class GetTransactionByIdRequest : IRequest<GetTransactionByIdResponse>
    {
        public int TransactionId { get; set; }
    }
}
