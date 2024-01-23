using Business.Constants;
using Business.Dtos.Language.Requests;
using Business.Dtos.Students.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class LanguageRequestValidator : AbstractValidator<CreateLanguageRequest>
    {
        public LanguageRequestValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            
        }
    }
}
