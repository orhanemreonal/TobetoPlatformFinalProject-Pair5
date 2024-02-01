using Business.Constants;
using Business.Dtos.PersonelInformations.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonalInformationRequestValidator : AbstractValidator<CreatePersonalInformationRequest>
    {
        public PersonalInformationRequestValidator()
        {
            
            RuleFor(p => p.IdentityNo).NotEmpty().WithMessage(Messages.MustFilling).Length(11).WithMessage(Messages.MustFillingForSubscribtions); 
            RuleFor(p => p.Address).NotEmpty().WithMessage(Messages.MustFilling);
            RuleFor(p => p.PhoneNumber).NotEmpty().WithMessage(Messages.MustFilling).MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar); ;
            RuleFor(p => p.BirthDate).NotEmpty();
            

        }


    }
}
