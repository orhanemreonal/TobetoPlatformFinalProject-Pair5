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


        public Task CheckIfCategoryNotExist(Category? category)
        {
            if (category == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfCategoryExist(Category? category)
        {
            if (category != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfCategoryNotExist(Guid id)
        {
            Category category = _categoryDal.Get(a => a.Id == id);
            CheckIfCategoryNotExist(category);
        }
    }
}
