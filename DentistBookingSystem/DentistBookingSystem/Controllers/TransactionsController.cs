using DentistBookingSystem.ApplicationServices.API.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ApiControllerBase
    {
        
        public TransactionsController(IMediator mediator, ILogger<TransactionsController> logger) : base(mediator)
        {
            logger.LogInformation("We are in Transaction Controller");
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllTransactions([FromQuery] GetTransactionRequest request)
        {
            return this.HandleRequest<GetTransactionRequest, GetTransactionResponse>(request);
        }

        [HttpGet]
        [Route("{transactionId}")]
        public Task<IActionResult> GetTransactionID([FromRoute] int transactionId)
        {
            var request = new GetTransactionByIdRequest
            {
                TransactionId = transactionId
            };
            return this.HandleRequest<GetTransactionByIdRequest, GetTransactionByIdResponse>(request);
        }
    }
}
