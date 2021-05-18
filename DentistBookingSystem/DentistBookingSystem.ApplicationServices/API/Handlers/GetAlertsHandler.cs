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
    public class GetAlertsHandler : IRequestHandler<GetAlertRequest, GetAlertResponse>
    {
        private readonly IRepository<Alert> alertRepository;
        public GetAlertsHandler(IRepository<DentistBookingSystem.DataAccess.Entities.Alert> alertRepository)
        {
            this.alertRepository = alertRepository;
        }

        public async Task<GetAlertResponse> Handle(GetAlertRequest request, CancellationToken cancellationToken)
        {
            var alerts = await this.alertRepository.GetAll();

            var domainAlerts = alerts.Select(x => new Domain.Models.Alert
            {
                EmergencyLists = x.EmergencyLists,
                Info = x.Info
            });

            var response = new GetAlertResponse()
            {
                Data = domainAlerts.ToList()
            };

            return response;
        }
    }
}
