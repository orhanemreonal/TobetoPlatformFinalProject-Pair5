using Business.Constants;
using Business.Dtos.Auth.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserRequestValidator : AbstractValidator<RegisterAuthRequest>
    {
        public UserRequestValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty().WithMessage(Messages.MustFilling);
            RuleFor(r => r.FirstName).MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.LastName).NotEmpty().WithMessage(Messages.MustFilling);
            RuleFor(r => r.LastName).MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Email).NotEmpty().WithMessage(Messages.MustFilling);
            RuleFor(r => r.Email).EmailAddress();
            RuleFor(r => r.Email).NotEmpty().WithMessage(Messages.MustFilling);
            RuleFor(r => r.Password).MinimumLength(8).MaximumLength(10).WithMessage(Messages.MustContainAtMinTwoChar).WithMessage(Messages.MustContainAtMaxTenChar);

        }


    }
}
