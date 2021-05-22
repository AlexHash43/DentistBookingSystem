using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetAppointmentQuery : QueryBase<Appointment>
    {
        public int Id { get; set; }
        public override async Task<Appointment> Execute(AppointmentStorageContext context)
        {
            var appointment = await context.Appointments.FirstOrDefaultAsync(x => x.Id == this.Id);
            return appointment;
        }
    }
}
