﻿using AutoMapper;
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
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.UserName, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.BirthDate, y => y.MapFrom(z => z.BirthDate))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.PhoneNumber))
                .ForMember(x => x.Gender, y => y.MapFrom(z => z.Gender))
                .ForMember(x => x.Role, y => y.MapFrom(z => z.Role))
                .ForMember(x => x.ListOfAppointmentsReason, y => y.MapFrom(z => z.Appointments != null ? z.Appointments.Select(x => x.Reason) : new List<string>()));



            this.CreateMap<AddUsersRequest, DataAccess.Entities.User>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.UserName, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.Password, y => y.MapFrom(z => z.Password))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.BirthDate, y => y.MapFrom(z => z.BirthDate))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.PhoneNumber))
                .ForMember(x => x.Gender, y => y.MapFrom(z => z.Gender));

            this.CreateMap<DeleteUserByIdRequest, DataAccess.Entities.User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<UpdateUsersRequest, DataAccess.Entities.User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.UserName, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.Password, y => y.MapFrom(z => z.Password))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email))
                .ForMember(x => x.BirthDate, y => y.MapFrom(z => z.BirthDate))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.PhoneNumber))
                .ForMember(x => x.Gender, y => y.MapFrom(z => z.Gender))
                .ForMember(x => x.Role, y => y.MapFrom(z => z.Role));

            this.CreateMap<ValidateUserRequest, DataAccess.Entities.User>()
                .ForMember(x => x.UserName, y => y.MapFrom(z => z.Username));

        }
    }
}
