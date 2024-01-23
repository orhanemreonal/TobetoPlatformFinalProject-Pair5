using Business.Dtos.ClassroomCourse.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ClassroomCourseRequestValidator : AbstractValidator<CreateClassroomCourseRequest>
    {
        public ClassroomCourseRequestValidator()
        {
            //Ara tablo silinmeli
        }
    }
}
