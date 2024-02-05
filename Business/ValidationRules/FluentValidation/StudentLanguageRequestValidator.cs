using Business.Dtos.Students.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentLanguageRequestValidator : AbstractValidator<CreateStudentLanguageRequest>
    {
        public StudentLanguageRequestValidator()
        {
            RuleFor(p => p.LanguageLevelId).NotEmpty();

        }

    }


}
