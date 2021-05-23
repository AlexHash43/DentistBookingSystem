using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    public class DeleteAppointmrntByIdHandler : IRequestHandler<DeleteAppointmrntByIdRequest, DeleteAppointmrntByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
        public DeleteAppointmrntByIdHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }
        public async Task<DeleteAppointmrntByIdResponse> Handle(DeleteAppointmrntByIdRequest request, CancellationToken cancellationToken)
        {
            var appointment = this.mapper.Map<DataAccess.Entities.Appointment>(request);
            var command = new DeleteAppointmrntByIdCommand
            {
                Parameter = appointment
            };

            var appointmentFromDB = await this.commandExecutor.Execute(command);

            return new DeleteAppointmrntByIdResponse()
            {
                Data = this.mapper.Map<Domain.Models.Appointment>(appointmentFromDB)
            };
        }
    }
}
