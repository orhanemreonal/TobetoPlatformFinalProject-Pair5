using Business.Constants;
using Business.Dtos.Application.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ApplicationRequestValidator : AbstractValidator<CreateApplicationRequest>
    {
        public ApplicationRequestValidator()
        {
            RuleFor(p => p.Description).NotEmpty().MinimumLength(25).WithMessage(Messages.MustContainAtMinTwentyfiveChar);

        }
    }
}
