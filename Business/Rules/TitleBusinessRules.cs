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

        public Task TitleShouldExistWhenSelected(Title? title)
        {
            if (title == null)
                throw new BusinessException(Messages.TitleNotExists);
            return Task.CompletedTask;
        }

        public async Task TitleIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Title? title = await _titleDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await TitleShouldExistWhenSelected(title);
        }
    }
}
