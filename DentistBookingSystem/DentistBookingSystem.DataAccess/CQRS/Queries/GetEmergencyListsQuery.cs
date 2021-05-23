using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetEmergencyListsQuery : QueryBase<List<EmergencyList>>
    {
        public async override Task<List<EmergencyList>> Execute(AppointmentStorageContext context)
        {
            return await context.EmergencyLists.ToListAsync();
            
        }
    }
}
