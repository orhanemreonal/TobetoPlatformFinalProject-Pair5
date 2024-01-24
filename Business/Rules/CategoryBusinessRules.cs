using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class CategoryBusinessRules : BaseBusinessRules
    {
        ICategoryDal _categoryDal;

        public CategoryBusinessRules(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Task CategoryShouldExistWhenSelected(Category? category)
        {
            if (category == null)
                throw new BusinessException(Messages.CategoryNotExists);
            return Task.CompletedTask;
        }

        public async Task CategoryIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Category? category = await _categoryDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await CategoryShouldExistWhenSelected(category);
        }
    }
}
