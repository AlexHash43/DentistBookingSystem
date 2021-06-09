using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
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
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;
        public GetUsersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUsersQuery()
            { 
                Name = request.Name,
                BirthDate = request.BirthDate
            };
            var users = await this.queryExecutor.Execute(query);
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
