using Business.Constants;
using Business.Dtos.Experience.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ExperienceRequestValidator : AbstractValidator<CreateExperienceRequest>
    {
        public ExperienceRequestValidator()
        {
            RuleFor(r => r.CompanyName).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Position).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Sector).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.JobDescription).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar).MaximumLength(300).WithMessage(Messages.MaxJobDescriptionChar);

        }
    }
}
