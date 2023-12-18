using Business.Constants;
using Business.Dtos.Users.Requests;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public UserRequestValidator()
        {
            RuleFor(r => r.FirstName).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.LastName).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Email).NotEmpty().EmailAddress();
            RuleFor(r => r.PasswordSalt).MinimumLength(8).MaximumLength(10).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar).WithMessage(Messages.MustContainAtMaxTenChar);

           


        }

        
    }
}
