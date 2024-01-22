using Business.Dtos.StudentLike.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentLikeRequestValidator : AbstractValidator<CreateStudentLikeRequest>
    {
        public StudentLikeRequestValidator()
        {

        }

    }
}
