using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Authentication;
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
    public class ValidateUserHandler : IRequestHandler<ValidateUserRequest, ValidateUserResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public ValidateUserHandler(IQueryExecutor queryExecutor,  IMapper mapper)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<ValidateUserResponse> Handle(ValidateUserRequest request, CancellationToken cancellationToken)
        {
            var query = new ValidateUserQuery()
            {
                UserName = request.Username
            };
            var user = await this.queryExecutor.Execute(query);

            if (user == null)
            {
                return new ValidateUserResponse
                {
                    Error = new ErrorModel(ErrorType.NotFound)
                };
            }

            PasswordHashing passwordHashing = new PasswordHashing
            {
                Password = request.Password,
                Salt = user.Salt
            };
            var hashedPassword = passwordHashing.Login();

            if (user.UserName != request.Username && user.Password != hashedPassword)
            {
                return new ValidateUserResponse
                {
                    Error = new ErrorModel(ErrorType.NotAuthenticated)
                };
            }

            var mappedUser = this.mapper.Map<Domain.Models.User>(user);
           

            var response = new ValidateUserResponse()
            {
                Data = mappedUser
            };
            return response;
        }
    }
}
