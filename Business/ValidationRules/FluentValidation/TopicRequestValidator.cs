using Business.Constants;
using Business.Dtos.Topic.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TopicRequestValidator : AbstractValidator<CreateTopicRequest>
    {
        public TopicRequestValidator()
        {
            

        }

    }
}
