using Business.Constants;
using Business.Dtos.VirtualClass.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class VirtualClassRequestValidator : AbstractValidator<CreateVirtualClassRequest>
    {
        public VirtualClassRequestValidator()
        {
            RuleFor(r=>r.StartTime).NotEmpty().WithMessage(Messages.NotBeEmpty);
            RuleFor(r=>r.FinishTime).NotEmpty().WithMessage(Messages.NotBeEmpty);

        }

    }
}
