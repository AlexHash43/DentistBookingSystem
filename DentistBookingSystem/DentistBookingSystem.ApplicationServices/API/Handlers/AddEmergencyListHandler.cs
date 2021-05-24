using AutoMapper;
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
    public class AddEmergencyListHandler : IRequestHandler<AddEmergencyListRequest, AddEmergencyListResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
        public AddEmergencyListHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }
        public async Task<AddEmergencyListResponse> Handle(AddEmergencyListRequest request, CancellationToken cancellationToken)
        {
            var emergencyList = mapper.Map<EmergencyList>(request);

            var command = new AddEmergencyListCommand
            { Parameter = emergencyList };

            var emergencyListFromDB = await this.commandExecutor.Execute(command);

            return new AddEmergencyListResponse()
            { Data = this.mapper.Map<Domain.Models.EmergencyList>(emergencyListFromDB) };

        }
    }
}
