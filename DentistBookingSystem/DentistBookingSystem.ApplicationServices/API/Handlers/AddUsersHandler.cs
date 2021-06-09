using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Authentication;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Commands;
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
    public class AddUsersHandler : IRequestHandler<AddUsersRequest, AddUsersResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public AddUsersHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }
        ///
        public async Task<AddUsersResponse> Handle(AddUsersRequest request, CancellationToken cancellationToken)
        {
            var user = this.mapper.Map<User>(request);
            
            /* Added Extra information b4 adding to database
             * New User always will be Patient
             */
            PasswordHashing passwordHashing = new PasswordHashing(user.Password);
            var newHash = passwordHashing.CreateNewPassword();
            user.Password = newHash.Password;
            user.Salt = newHash.Salt;
            user.Role = 0;
            

            var command = new AddUsersCommand() { Parameter = user };

           var userFromDB =  await this.commandExecutor.Execute(command);

            return new AddUsersResponse()
            {
                Data = this.mapper.Map<Domain.Models.User>(userFromDB)
            };
        }
    }
}

