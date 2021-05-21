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
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            this.CreateMap<DentistBookingSystem.DataAccess.Entities.User, User>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname));



            this.CreateMap<AddUsersRequest, DataAccess.Entities.User>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.BirthDate, y => y.MapFrom(z => z.BirthDate))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.PhoneNumber))
                .ForMember(x => x.Gender, y => y.MapFrom(z => z.Gender));

        }
    }
}
