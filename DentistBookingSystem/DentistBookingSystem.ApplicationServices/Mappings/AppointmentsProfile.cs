using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.ApplicationServices.API.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace DentistBookingSystem.ApplicationServices.Mappings
{
    public class AppointmentsProfile : Profile
    {
        public AppointmentsProfile()
        {
            this.CreateMap<DentistBookingSystem.DataAccess.Entities.Appointment, Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.DateStart, y => y.MapFrom(z => z.DateStart))
                .ForMember(x => x.DateStop, y => y.MapFrom(z => z.DateStop))
                .ForMember(x => x.Note, y => y.MapFrom(z => z.Note))
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason))
                .ForMember(x => x.UserName, y => y.MapFrom(z => z.Users != null ? z.Users.Select(x => x.Name) : new List<string>()));

            this.CreateMap<AddAppointmentRequest, DataAccess.Entities.Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.DateStart, y => y.MapFrom(z => z.DateStart))
                .ForMember(x => x.DateStop, y => y.MapFrom(z => z.DateStop))
                .ForMember(x => x.Note, y => y.MapFrom(z => z.Note))
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason));

            this.CreateMap<UpdateAppointmentRequest, DataAccess.Entities.Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.DateStart, y => y.MapFrom(z => z.DateStart))
                .ForMember(x => x.DateStop, y => y.MapFrom(z => z.DateStop))
                .ForMember(x => x.Note, y => y.MapFrom(z => z.Note))
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason));

            this.CreateMap<DeleteAppointmrntByIdRequest, DataAccess.Entities.Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

        }
    }
}
