using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    public class UpdateUsersHandler : IRequestHandler<UpdateUsersRequest, UpdateUsersResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public UpdateUsersHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<UpdateUsersResponse> Handle(UpdateUsersRequest request, CancellationToken cancellationToken)
        {
            var user = this.mapper.Map<DataAccess.Entities.User>(request);
            var command = new UpdateUsersCommand() { Parameter = user };

            var userFromDB = await this.commandExecutor.Execute(command);

            return new UpdateUsersResponse()
            {
                Data = this.mapper.Map<Domain.Models.User>(userFromDB)
            };
        }
    }
}
