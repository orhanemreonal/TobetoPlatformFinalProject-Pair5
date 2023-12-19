using Business.Dtos.Course.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseRequestValidator : AbstractValidator<CreateCourseRequest>
    {
        public CourseRequestValidator()
        {

        }
    }
}
