using Business.Constants;
using Business.Dtos.PersonelInformations.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonalInformationRequestValidator : AbstractValidator<CreatePersonalInformationRequest>
    {
        public PersonalInformationRequestValidator()
        {
            RuleFor(p => p.About).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(p => p.IdentityNo).NotEmpty().MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar); ;
            RuleFor(p => p.Address).NotEmpty();
            RuleFor(p => p.PhoneNumber).NotEmpty();
            RuleFor(p => p.PhoneNumber).MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar); ;
            RuleFor(p => p.BirthDate).NotEmpty();

        }


    }
}
