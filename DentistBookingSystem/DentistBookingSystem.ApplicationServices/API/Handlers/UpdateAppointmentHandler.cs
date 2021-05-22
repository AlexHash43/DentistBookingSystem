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
    public class UpdateAppointmentHandler : IRequestHandler<UpdateAppointmentRequest, UpdateAppointmentResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
        public UpdateAppointmentHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
                
        }
        public async Task<UpdateAppointmentResponse> Handle(UpdateAppointmentRequest request, CancellationToken cancellationToken)
        {
            var appointment = this.mapper.Map<DataAccess.Entities.Appointment>(request);
            var command = new UpdateAppointmentCommand() { Parameter = appointment };

            var appointmentFromDB = await this.commandExecutor.Execute(command);

            return new UpdateAppointmentResponse()
            {
                Data = this.mapper.Map<Domain.Models.Appointment>(appointmentFromDB)
            };
        }
    }
}
