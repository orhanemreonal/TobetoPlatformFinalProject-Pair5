using Business.Constants;
using Business.Dtos.Announcement.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AnnouncementRequestValidator : AbstractValidator<CreateAnnouncementRequest>
    {
        public AnnouncementRequestValidator()
        {
            RuleFor(p => p.Type).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(p => p.Organization).NotEmpty().MinimumLength(11).WithMessage(Messages.MustContainAtMinElevenChar); ;
            RuleFor(p => p.Title).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(p => p.Description).NotEmpty().MinimumLength(25).WithMessage(Messages.MustContainAtMinTwentyfiveChar);



        }
    }
}
