using Business.Dtos.Like.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class LikeRequestValidator : AbstractValidator<CreateLikeRequest>
    {
        public LikeRequestValidator()
        {

        }
    }
}
