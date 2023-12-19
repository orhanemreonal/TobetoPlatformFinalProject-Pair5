using Business.Dtos.Exam.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ExamRequestValidator : AbstractValidator<CreateExamRequest>
    {
        public ExamRequestValidator()
        {

        }
    }
}
