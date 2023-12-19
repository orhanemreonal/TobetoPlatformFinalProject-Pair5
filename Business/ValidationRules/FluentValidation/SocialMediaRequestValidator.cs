using Business.Constants;
using Business.Dtos.SocialMedias.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SocialMediaRequestValidator: AbstractValidator<CreateSocialMediaRequest>
    {
        public SocialMediaRequestValidator()
        {
            RuleFor(s => s.Name).NotEmpty();
            RuleFor(s => s.Name).MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(s => s.Url).NotEmpty();

        }

    }
}
