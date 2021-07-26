using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.Mappings
{
    public class EmergencyListsProfile : Profile
    {
        public EmergencyListsProfile()
        {
            this.CreateMap<DentistBookingSystem.DataAccess.Entities.EmergencyList, EmergencyList>()
               .ForMember(x => x.UserId, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.AlertId, y => y.MapFrom(z => z.AlertId));

            this.CreateMap<AddEmergencyListRequest, DataAccess.Entities.EmergencyList>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.AlertId, y => y.MapFrom(z => z.AlertId));




        }
    }
}
