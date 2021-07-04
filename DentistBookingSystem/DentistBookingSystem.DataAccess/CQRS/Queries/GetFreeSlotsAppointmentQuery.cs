using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetFreeSlotsAppointmentQuery : QueryBase<List<Appointment>>
    {
        public override Task<List<Appointment>> Execute(AppointmentStorageContext context)
        {
            return context.Appointments.Where(x => x.StatusBooked == false && x.UsersId == null).ToListAsync();
        }
    }
}
