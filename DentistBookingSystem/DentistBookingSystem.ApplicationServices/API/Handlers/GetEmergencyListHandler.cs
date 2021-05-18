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
    public class GetEmergencyListHandler : IRequestHandler<GetEmergencyListRequest, GetEmergencyListResponse>
    {
        private readonly IRepository<EmergencyList> emergencyListRepository;
        public GetEmergencyListHandler(IRepository<DentistBookingSystem.DataAccess.Entities.EmergencyList> emergencyListRepository)
        {
            this.emergencyListRepository = emergencyListRepository;
        }
        public async Task<GetEmergencyListResponse> Handle(GetEmergencyListRequest request, CancellationToken cancellationToken)
        {
            var emergrncyList = await this.emergencyListRepository.GetAll();

            var domainEmergencyList = emergrncyList.Select(x => new Domain.Models.EmergencyList
            {
                AlertId = x.AlertId,
                User = x.User,
                UserId = x.UserId
            });

            var response = new GetEmergencyListResponse()
            {
                Data = domainEmergencyList.ToList()
             };

            return response;
        }
    }
}
