﻿using AutoMapper;
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
    public class DeleteUserByIdHandler : IRequestHandler<DeleteUserByIdRequest, DeleteUserByIdResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;
        public DeleteUserByIdHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }
        public async Task<DeleteUserByIdResponse> Handle(DeleteUserByIdRequest request, CancellationToken cancellationToken)
        {
            var user = this.mapper.Map<User>(request);
            var command = new DeleteUserByIdCommand()
            {
                Parameter = user
            };

            var userFromDB = await this.commandExecutor.Execute(command);

            return new DeleteUserByIdResponse()
            {
                Data = this.mapper.Map<Domain.Models.User>(userFromDB)
            };

        }
    }
}
