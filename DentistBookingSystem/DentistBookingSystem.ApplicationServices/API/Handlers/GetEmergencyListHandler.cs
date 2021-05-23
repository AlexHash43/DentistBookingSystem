using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
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
    public class GetEmergencyListHandler : IRequestHandler<GetEmergencyListRequest, GetEmergencyListResponse>
    {
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public GetEmergencyListHandler(IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetEmergencyListResponse> Handle(GetEmergencyListRequest request, CancellationToken cancellationToken)
        {
            var query = new GetEmergencyListsQuery();
            var emergencyLists = await this.queryExecutor.Execute(query);
            var mappedEmergencyLists = this.mapper.Map<List<API.Domain.Models.EmergencyList>>(emergencyLists);
            var response = new GetEmergencyListResponse()
            { Data = mappedEmergencyLists };
            return response;



        }
    }
}
