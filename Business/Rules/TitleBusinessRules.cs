using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class TitleBusinessRules : BaseBusinessRules
    {
        ITitleDal _titleDal;

        public TitleBusinessRules(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public Task CheckIfTitleNotExist(Title? title)
        {
            if (title == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfTitleExist(Title? title)
        {
            if (title != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfTitleNotExist(Guid id)
        {
            Title title = _titleDal.Get(a => a.Id == id);
            CheckIfTitleNotExist(title);
        }
    }
}
