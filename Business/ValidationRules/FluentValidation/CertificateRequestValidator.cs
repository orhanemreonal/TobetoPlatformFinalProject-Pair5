using Business.Constants;
using Business.Dtos.Certificate.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CertificateRequestValidator : AbstractValidator<CreateCertificateRequest>
    {
        public CertificateRequestValidator()
        {
            RuleFor(r => r.FileName).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.FilePath).NotEmpty();
        }
    }
}
