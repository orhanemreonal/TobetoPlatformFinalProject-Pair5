using Business.Constants;
using Business.Dtos.Title.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TitleRequestValidator : AbstractValidator<CreateTitleRequest>
    {
        public TitleRequestValidator()
        {
            

        }

    }
}
