using Business.Dtos.CourseTopic.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseTopicRequestValidator : AbstractValidator<CreateCourseTopicRequest>
    {
        public CourseTopicRequestValidator()
        {

        }
    }
}
