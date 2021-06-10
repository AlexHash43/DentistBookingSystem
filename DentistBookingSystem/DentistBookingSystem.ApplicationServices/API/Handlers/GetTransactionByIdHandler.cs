using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.ApplicationServices.API.ErrorHandling;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    class GetTransactionByIdHandler : IRequestHandler<GetTransactionByIdRequest, GetTransactionByIdResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public GetTransactionByIdHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetTransactionByIdResponse> Handle(GetTransactionByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetTransactionQuery
            {
                Id = request.TransactionId
            };

            var transaction = await this.queryExecutor.Execute(query);

            if (transaction == null)
            {
                return new GetTransactionByIdResponse
                {
                    Error = new ErrorModel(ErrorType.NotFound)
                };
            }
            var mappedTransaction = this.mapper.Map<Domain.Models.Transaction>(transaction);
            var response = new GetTransactionByIdResponse()
            {
                Data = mappedTransaction
            };

            return response;
        }
    }
}
