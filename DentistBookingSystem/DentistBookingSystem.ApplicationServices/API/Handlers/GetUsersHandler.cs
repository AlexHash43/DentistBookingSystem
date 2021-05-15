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
        public GetUsersHandler(IRepository<DentistBookingSystem.DataAccess.Entities.User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var users = this.userRepository.GetAll();
            //var domainUsers = new List<Domain.Models.User>();
            //foreach (var user in users)
            //{
            //    domainUsers.Add(new Domain.Models.User()
            //    {
            //        Name = user.Name,
            //        Surname = user.Surname
            //    });

            //}
            var domainUsers = users.Select(x => new Domain.Models.User()
            {
                Name = x.Name,
                Surname = x.Surname
            });

            var response = new GetUserResponse()
            {
                Data = domainUsers.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
