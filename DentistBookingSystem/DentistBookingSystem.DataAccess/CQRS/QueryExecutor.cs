using DentistBookingSystem.DataAccess.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly AppointmentStorageContext context;
        public QueryExecutor(AppointmentStorageContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
