using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.ApplicationServices.API.ErrorHandling;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    public class GetMeHandler : IRequestHandler<GetMeRequest, GetMeResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetMeHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetMeResponse> Handle(GetMeRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMeQuery()
            {
                Id = Int32.Parse(request.UserId)
            };

            var user = await this.queryExecutor.Execute(query);

            if (user == null)
            {
                return new GetMeResponse
                {
                    Error = new ErrorModel(ErrorType.NotFound)
                };
            }
            var mappedUser = this.mapper.Map<Domain.Models.User>(user);
            var response = new GetMeResponse()
            {
                Data = mappedUser
            };

            return response;
        }
    }
}
