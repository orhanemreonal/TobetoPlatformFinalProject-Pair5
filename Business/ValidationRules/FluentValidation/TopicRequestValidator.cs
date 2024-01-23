using Business.Constants;
using Business.Dtos.Topic.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TopicRequestValidator : AbstractValidator<CreateTopicRequest>
    {
        public TopicRequestValidator()
        {
            RuleFor(r => r.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar);
            RuleFor(r => r.Name).NotEmpty().MaximumLength(50).WithMessage(Messages.MustContainAtMaxFiftyChar);

        }

    }
}
