using Business.Dtos.Education.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class EducationRequestValidator : AbstractValidator<CreateEducationRequest>
    {
        public EducationRequestValidator()
        {

        }
    }
}
