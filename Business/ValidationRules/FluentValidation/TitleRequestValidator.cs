using Business.Constants;
using Business.Dtos.Title.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TitleRequestValidator : AbstractValidator<CreateTitleRequest>
    {
        public TitleRequestValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Name).NotEmpty().MaximumLength(50).WithMessage(Messages.MustContainAtMaxFiftyChar);
            RuleFor(r => r.Description).NotEmpty().MinimumLength(10).WithMessage(Messages.MustContainAtMinTenChar);
            RuleFor(r => r.Description).NotEmpty().MaximumLength(250).WithMessage(Messages.MaximumCharCount);
            RuleFor(r => r.Point).NotEmpty().InclusiveBetween(0, 100).WithMessage(Messages.PointMustBetween);
            RuleFor(r => r.Subtype).NotEmpty().Length(2, 50);
            RuleFor(r => r.VideoLanguage).NotEmpty();
            RuleFor(r => r.VideoLink).NotEmpty().MinimumLength(8).WithMessage(Messages.MustContainMinEightChar);


        }

        

    }
}
