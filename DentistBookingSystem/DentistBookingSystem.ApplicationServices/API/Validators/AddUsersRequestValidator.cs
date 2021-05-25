using DentistBookingSystem.ApplicationServices.API.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Validators
{
    public class AddUsersRequestValidator : AbstractValidator<AddUsersRequest>
    {
        public AddUsersRequestValidator()
        {
            this.RuleFor(x => x.Name).Length(1,50);
            this.RuleFor(x => x.Surname).Length(1, 50);
            this.RuleFor(x => x.Email).Length(1, 50);
        }
    }
}
