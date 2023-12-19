using Business.Constants;
using Business.Dtos.Company.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CompanyRequestValidator : AbstractValidator<CreateCompanyRequest>
    {
        public CompanyRequestValidator()
        {
            RuleFor(r => r.Name).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);

        }


    }
}
