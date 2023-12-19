using Business.Dtos.ClassCourse.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ClassCourseRequestValidator : AbstractValidator<CreateClassCourseRequest>
    {
        public ClassCourseRequestValidator()
        {
        }
    }
}
