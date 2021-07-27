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
                .ForMember(x => x.TimeStart, y => y.MapFrom(z => z.TimeStart))
                .ForMember(x => x.DateStart, y => y.MapFrom(z => z.DateStart))
                .ForMember(x => x.TimeStop, y => y.MapFrom(z => z.TimeStop))
                .ForMember(x => x.DateStop, y => y.MapFrom(z => z.DateStop))
                .ForMember(x => x.TimeAndDateBooked, y => y.MapFrom(z => z.TimeAndDateBooked))
                .ForMember(x => x.Note, y => y.MapFrom(z => z.Note))
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason))
                .ForMember(x => x.UserId, y => y.MapFrom(z => z.UsersId));




            this.CreateMap<AddAppointmentRequest, DataAccess.Entities.Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.TimeStart, y => y.MapFrom(z => z.TimeStart))
                .ForMember(x => x.DateStart, y => y.MapFrom(z => z.DateStart))
                .ForMember(x => x.TimeStop, y => y.MapFrom(z => z.TimeStop))
                .ForMember(x => x.DateStop, y => y.MapFrom(z => z.DateStop))
                .ForMember(x => x.TimeAndDateBooked, y => y.MapFrom(z => z.TimeAndDateBooked))
                .ForMember(x => x.Note, y => y.MapFrom(z => z.Note))
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason))
                .ForMember(x => x.UsersId, y => y.MapFrom(z => z.UserId));

            this.CreateMap<UpdateAppointmentRequest, DataAccess.Entities.Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.TimeStart, y => y.MapFrom(z => z.TimeStart))
                .ForMember(x => x.DateStart, y => y.MapFrom(z => z.DateStart))
                .ForMember(x => x.TimeStop, y => y.MapFrom(z => z.TimeStop))
                .ForMember(x => x.DateStop, y => y.MapFrom(z => z.DateStop))
                .ForMember(x => x.TimeAndDateBooked, y => y.MapFrom(z => z.TimeAndDateBooked))
                .ForMember(x => x.Note, y => y.MapFrom(z => z.Note))
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason))
                .ForMember(x => x.UsersId, y => y.MapFrom(z => z.UserId));

            this.CreateMap<DeleteAppointmrntByIdRequest, DataAccess.Entities.Appointment>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));



            
        }
    }
}
