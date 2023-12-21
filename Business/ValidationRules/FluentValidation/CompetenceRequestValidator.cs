using Business.Constants;
using Business.Dtos.Competence.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CompetenceRequestValidator : AbstractValidator<CreateCompetenceRequest>
    {
        public CompetenceRequestValidator()
        {
            RuleFor(r => r.Name).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);

        }

    }
}
