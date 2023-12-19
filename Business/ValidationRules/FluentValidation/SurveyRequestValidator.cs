using Business.Dtos.Survey.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SurveyRequestValidator : AbstractValidator<CreateSurveyRequest>
    {
        public SurveyRequestValidator()
        {

        }
    }
}
