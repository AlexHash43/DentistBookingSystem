using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    public class GetFreeSlotsAppointmentHandler : IRequestHandler<GetFreeSlotsAppointmentRequest, GetFreeSlotsAppointmentResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public GetFreeSlotsAppointmentHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }


        public async Task<GetFreeSlotsAppointmentResponse> Handle(GetFreeSlotsAppointmentRequest request, CancellationToken cancellationToken)
        {
            var query = new GetFreeSlotsAppointmentQuery();
            var freeSlots = await this.queryExecutor.Execute(query);
            var mappedFreeSlots = this.mapper.Map<List<Domain.Models.Appointment>>(freeSlots);





            var response = new GetFreeSlotsAppointmentResponse()
            {
                Data = mappedFreeSlots
            };
            return response;
        }
    }
}
