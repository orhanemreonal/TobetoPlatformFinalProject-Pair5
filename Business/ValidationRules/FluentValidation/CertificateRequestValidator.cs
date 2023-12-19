using Business.Constants;
using Business.Dtos.Certificate.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CertificateRequestValidator : AbstractValidator<CreateCertificateRequest>
    {
        public CertificateRequestValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Folder).NotEmpty(); 
        }
    }
}
