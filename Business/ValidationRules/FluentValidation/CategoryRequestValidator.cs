using Business.Dtos.Category.Requests;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryRequestValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CategoryRequestValidator()
        {

        }
    }
}
