using Business.Constants;
using Business.Dtos.SocialMedias.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SocialMediaRequestValidator : AbstractValidator<CreateSocialMediaRequest>
    {
        public SocialMediaRequestValidator()
        {
            RuleFor(s => s.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);

        }

    }
}
