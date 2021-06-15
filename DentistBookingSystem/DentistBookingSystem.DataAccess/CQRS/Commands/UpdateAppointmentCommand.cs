using DentistBookingSystem.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Commands
{
    public class UpdateAppointmentCommand : CommandBase<Appointment, Appointment>
    {
        public async override Task<Appointment> Execute(AppointmentStorageContext context)
        {
            context.Appointments.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
