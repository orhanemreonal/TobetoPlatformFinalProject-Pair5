using Business.Constants;
using Business.Dtos.Auth.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserRequestValidator : AbstractValidator<RegisterAuthRequest>
    {
        public UserRequestValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty().WithMessage(Messages.MustFilling).MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.LastName).NotEmpty().WithMessage(Messages.MustFilling).MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Email).NotEmpty().WithMessage(Messages.MustFilling).Must(ValidateEmail).WithMessage(Messages.InvalidEmail);
            RuleFor(r => r.Password).NotEmpty().WithMessage(Messages.MustFilling).MinimumLength(6).MaximumLength(50).Must(ValidatePassword).WithMessage(Messages.MustContainMinEightChar).WithMessage(Messages.MustContainAtMaxFiftyChar).WithMessage(Messages.MustContainUpperLowerChar);

        }
        private bool ValidateEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private bool ValidatePassword(string password)
        {
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

    }
}
