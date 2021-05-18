using AutoMapper;
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
    public class GetUsersHandler : IRequestHandler<GetUserRequest, GetUserResponse>
    {
        private readonly IRepository<User> userRepository;
        private readonly IMapper mapper;
        public GetUsersHandler(
            IRepository<DentistBookingSystem.DataAccess.Entities.User> userRepository, 
            IMapper mapper
            )
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var users = await this.userRepository.GetAll();
            var mappedUsers = this.mapper.Map<List<Domain.Models.User>>(users);
            //var domainUsers = new List<Domain.Models.User>();
            //foreach (var user in users)
            //{
            //    domainUsers.Add(new Domain.Models.User()
            //    {
            //        Name = user.Name,
            //        Surname = user.Surname
            //    });

            //}


            //var domainUsers = users.Select(x => new Domain.Models.User()
            //{
            //    Name = x.Name,
            //    Surname = x.Surname
            //});





            var response = new GetUserResponse()
            {
                Data = mappedUsers
            };
            return response;
        }
    }
}
