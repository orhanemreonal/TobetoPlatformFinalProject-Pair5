using Business.Constants;
using Business.Dtos.Classroom.Requests;
using FluentValidation;


namespace Business.ValidationRules.FluentValidation
{
    public class ClassroomRequestValidator : AbstractValidator<CreateClassroomRequest>
    {
        public ClassroomRequestValidator()
        {
            RuleFor(r => r.Name).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);

        }


    }
}
