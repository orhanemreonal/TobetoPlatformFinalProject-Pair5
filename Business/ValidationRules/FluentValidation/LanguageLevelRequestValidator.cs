using Business.Constants;
using Business.Dtos.LanguageLevel.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class LanguageLevelRequestValidator : AbstractValidator<CreateLanguageLevelRequest>
    {
        public LanguageLevelRequestValidator()
        {
            RuleFor(r => r.Level).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);

        }
    }
}
