using Business.Constants;
using Business.Dtos.VirtualClass.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class VirtualClassRequestValidator : AbstractValidator<CreateVirtualClassRequest>
    {
        public VirtualClassRequestValidator()
        {
            

        }

    }
}
