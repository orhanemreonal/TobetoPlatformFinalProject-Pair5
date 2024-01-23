using Business.Constants;
using Business.Dtos.Course.Requests;
using FluentValidation;



namespace Business.ValidationRules.FluentValidation
{
    public class CourseRequestValidator : AbstractValidator<CreateCourseRequest>
    {
        public CourseRequestValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.ImageUrl).NotEmpty().MinimumLength(8).WithMessage(Messages.MustContainMinEightChar);
            RuleFor(r => r.About).NotEmpty().MinimumLength(8).WithMessage(Messages.MustContainMinEightChar);
        }
    }
}
