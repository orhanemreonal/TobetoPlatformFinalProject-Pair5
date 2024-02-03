using Business.Constants;
using Business.Dtos.Education.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EducationRequestValidator : AbstractValidator<CreateEducationRequest>
    {
        public EducationRequestValidator()
        {
            RuleFor(r => r.EducationalStatus).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.University).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar).MaximumLength(50).WithMessage(Messages.MustContainAtMaxFiftyChar);
            RuleFor(r => r.EducationalStatus).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Department).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar).MaximumLength(50).WithMessage(Messages.MustContainAtMaxFiftyChar);


        }
    }
}
