using Business.Constants;
using Business.Dtos.Course.Requests;
using FluentValidation;



namespace Business.ValidationRules.FluentValidation
{
    public class CourseRequestValidator : AbstractValidator<CreateCourseRequest>
    {
        public CourseRequestValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(p => p.ImageUrl).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar); ;
            RuleFor(p => p.About).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar); ;


        }
    }
}
