using Business.Constants;
using Business.Dtos.PersonelInformations.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonalInformationRequestValidator : AbstractValidator<CreatePersonalInformationRequest>
    {
        public PersonalInformationRequestValidator()
        {
            RuleFor(p => p.IdentityNo).NotEmpty();
            RuleFor(p => p.IdentityNo).NotEmpty().MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar); ;
            RuleFor(p => p.Address).NotEmpty();
            RuleFor(p => p.PhoneNumber).NotEmpty();
            RuleFor(p => p.PhoneNumber).MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar); ;
            RuleFor(p => p.BirthDate).NotEmpty();

        }


    }
}
