using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.Mappings
{
    class TransactionsProfile : Profile
    {
        public TransactionsProfile()
        {
            this.CreateMap<DentistBookingSystem.DataAccess.Entities.Transaction, Transaction>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Price, y => y.MapFrom(z => z.Price))
                .ForMember(x => x.UserId, y => y.MapFrom(z => z.UsersId));
        }
    }
}
