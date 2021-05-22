using DentistBookingSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Commands
{
    public class AddAppointmentCommand : CommandBase<Appointment, Appointment>
    {
        public async override Task<Appointment> Execute(AppointmentStorageContext context)
        {
            await context.Appointments.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
