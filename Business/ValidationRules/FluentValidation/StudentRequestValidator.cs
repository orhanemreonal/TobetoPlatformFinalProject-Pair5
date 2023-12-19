using Business.Dtos.Student.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentRequestValidator : AbstractValidator<CreateStudentRequest>
    {
        public StudentRequestValidator()
        {

        }
    }
}
