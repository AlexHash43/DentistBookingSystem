using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetTransactionQuery : QueryBase<Transaction>
    {
        public int Id { get; set; }
        public async override Task<Transaction> Execute(AppointmentStorageContext context)
        {
            var transaction = await context.Transactions.FirstOrDefaultAsync(x => x.Id == Id);
            return transaction;
        }
    }
}
