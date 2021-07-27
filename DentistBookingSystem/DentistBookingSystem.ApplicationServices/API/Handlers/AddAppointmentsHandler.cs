using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.ApplicationServices.API.ErrorHandling;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Commands;
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
    class AddAppointmentsHandler : IRequestHandler<AddAppointmentRequest, AddAppointmentResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
        

        public AddAppointmentsHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddAppointmentResponse> Handle(AddAppointmentRequest request, CancellationToken cancellationToken)
        {
            
            var appointment = this.mapper.Map<Appointment>(request);

            /*
             * TO FIX
             * 
             */
            //if (!(appointment.TimeStart < appointment.TimeStop))
            //{
            //    return new AddAppointmentResponse { Error = new ErrorModel(ErrorType.WrongDateTimeRange) };
            //}



            //if (appointment.TimeStart.Ticks < DateTime.Now.Ticks)
            //{
            //    return new AddAppointmentResponse { Error = new ErrorModel("This time and date is unavalable") };
            //}
            if(appointment.UsersId != null )
            {
                appointment.StatusBooked = true;
            }
            var command = new AddAppointmentCommand() { Parameter = appointment };

            var appointmentFromDB = await this.commandExecutor.Execute(command);

            return new AddAppointmentResponse()
            {
                Data = this.mapper.Map<Domain.Models.Appointment>(appointmentFromDB)
            };
        }
    }
}
