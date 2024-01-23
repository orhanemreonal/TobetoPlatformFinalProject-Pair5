using Business.Constants;
using Business.Dtos.Category.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryRequestValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CategoryRequestValidator()
        {
            RuleFor(p => p.Name).NotEmpty().MinimumLength(2).WithMessage(Messages.MustContainAtMinTwoChar); ;

        }
    }
}
