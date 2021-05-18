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
    public class GetTransactionHandler : IRequestHandler<GetTransactionRequest, GetTransactionResponse>
    {
        private readonly IRepository<Transaction> transactionRepository;
        public GetTransactionHandler(IRepository<Transaction> transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public async Task<GetTransactionResponse> Handle(GetTransactionRequest request, CancellationToken cancellationToken)
        {
            var transaction = await this.transactionRepository.GetAll();

            var domainTransaction = transaction.Select(x => new Domain.Models.Transaction
            {
                Price = x.Price,
                User = x.User,
                UserId = x.UserId
            });

            var response = new GetTransactionResponse()
            {
                Data = domainTransaction.ToList()
            };

            return response;
        }
    }
}
