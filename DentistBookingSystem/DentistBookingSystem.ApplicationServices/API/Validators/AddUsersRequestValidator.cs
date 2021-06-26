using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Queries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Validators
{
    public class AddUsersRequestValidator : AbstractValidator<AddUsersRequest>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public AddUsersRequestValidator(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;


            this.RuleFor(x => x.Name).Length(1,50).WithMessage("WRONG_RANGE");
            this.RuleFor(x => x.Surname).Length(1, 50);
            this.RuleFor(x => x.Email).Length(5, 50).EmailAddress().MustAsync(NotBeInDatabase).WithMessage("This Email already exist in our database. Please choose different email address");

            this.RuleFor(x => x.Password).MinimumLength(8).WithMessage("MINIMUM_LENGTH_OF_PASSWORD_8");
        }

        private async Task<bool> NotBeInDatabase(string email, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery()
            {
                Email = email
            };
            var user = await this.queryExecutor.Execute(query);

            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
