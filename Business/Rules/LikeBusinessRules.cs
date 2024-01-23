using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class LikeBusinessRules : BaseBusinessRules
    {
        ILikeDal _likeDal;

        public LikeBusinessRules(ILikeDal likeDal)
        {
            _likeDal = likeDal;
        }

        public Task CheckIfLikeNotExist(Like? like)
        {
            if (like == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfLikeExist(Like? like)
        {
            if (like != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfLikeNotExist(Guid id)
        {
            Like like = _likeDal.Get(a => a.Id == id);
            CheckIfLikeNotExist(like);
        }
    }
}
