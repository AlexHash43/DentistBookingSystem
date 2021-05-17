using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess;
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
        private readonly IRepository<Appointment> appointmentRepository;
        public GetAppointmentHandler(IRepository<DentistBookingSystem.DataAccess.Entities.Appointment> appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        public Task<GetAppointmentResponse> Handle(GetAppointmentRequest request, CancellationToken cancellationToken)
        {
            var appointments = this.appointmentRepository.GetAll();

            var domainAppointmets = appointments.Select(x => new Domain.Models.Appointment
            {
                DateStart = x.DateStart,
                DateStop = x.DateStop,
                Note = x.Note,
                Reason = x.Reason
            });

            var response = new GetAppointmentResponse()
            {
                Data = domainAppointmets.ToList()
            };

            return Task.FromResult(response);
        }
    }
}
