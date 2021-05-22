using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
using DentistBookingSystem.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    public class GetAppointmentHandler : IRequestHandler<GetAppointmentRequest, GetAppointmentResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public GetAppointmentHandler(IQueryExecutor  queryExecutor, IMapper mapper)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetAppointmentResponse> Handle(GetAppointmentRequest request, CancellationToken cancellationToken)
        {
            var query = new GetAppointmentsQuery();
            
            var appointments = await this.queryExecutor.Execute(query);
            var mappedAppointments = this.mapper.Map<List<Domain.Models.Appointment>>(appointments);
            




            var response = new GetAppointmentResponse()
            {
                Data = mappedAppointments
            };
            return response;
        }
    }
}
