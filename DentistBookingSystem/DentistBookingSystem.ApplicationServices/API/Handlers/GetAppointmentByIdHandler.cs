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
    public class GetAppointmentByIdHandler : IRequestHandler<GetAppointmentByIdRequest, GetAppointmentByIdResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public GetAppointmentByIdHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }
        public async Task<GetAppointmentByIdResponse> Handle(GetAppointmentByIdRequest request, CancellationToken cancellationToken)
        {

            var query = new GetAppointmentQuery()
            {
                Id = request.Id
            };

            var appointment = await this.queryExecutor.Execute(query);
            var mappedAppointment = this.mapper.Map<Domain.Models.Appointment>(appointment);
            var response = new GetAppointmentByIdResponse()
            {
                Data = mappedAppointment
            };

            return response;
        }
    }
}
