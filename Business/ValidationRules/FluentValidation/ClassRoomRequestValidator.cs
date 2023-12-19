using Business.Constants;
using Business.Dtos.ClassRoom.Requests;
using FluentValidation;


namespace Business.ValidationRules.FluentValidation
{
    public class ClassRoomRequestValidator : AbstractValidator<CreateClassRoomRequest>
    {
        public ClassRoomRequestValidator()
        {
            RuleFor(r => r.Name).MinimumLength(2).NotEmpty().WithMessage(Messages.MustContainAtMinTwoChar);

        }


    }
}
