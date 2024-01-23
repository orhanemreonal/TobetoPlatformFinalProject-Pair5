using Business.Constants;
using Business.Dtos.Auth.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserRequestValidator : AbstractValidator<RegisterAuthRequest>
    {
        public UserRequestValidator()
        {
            RuleFor(r => r.FirstName).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.LastName).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Email).NotEmpty().Must(ValidateEmail).WithMessage(Messages.InvalidEmail);
            RuleFor(r => r.Password).MinimumLength(8).MaximumLength(10).NotEmpty().Must(ValidatePassword).WithMessage(Messages.MustContainAtMinTwoChar).WithMessage(Messages.MustContainAtMaxTenChar).WithMessage(Messages.MustContainUpperLowerChar);

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
            if(!password.Any(char.IsLower))
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
