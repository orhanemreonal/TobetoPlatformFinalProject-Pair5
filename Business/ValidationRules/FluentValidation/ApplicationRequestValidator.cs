using Business.Dtos.Application.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ApplicationRequestValidator : AbstractValidator<CreateApplicationRequest>
    {
        public ApplicationRequestValidator()
        {

        }
    }
}
