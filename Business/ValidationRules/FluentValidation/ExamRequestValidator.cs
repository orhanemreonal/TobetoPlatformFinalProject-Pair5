using Business.Constants;
using Business.Dtos.Exam.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ExamRequestValidator : AbstractValidator<CreateExamRequest>
    {
        public ExamRequestValidator()
        {
            RuleFor(r => r.Title).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Description).NotEmpty().MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar);

        }
    }
}
