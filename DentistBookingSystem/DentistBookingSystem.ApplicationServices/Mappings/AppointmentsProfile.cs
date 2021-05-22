using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain.Models;

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
                .ForMember(x => x.Reason, y => y.MapFrom(z => z.Reason));
        }
    }
}
