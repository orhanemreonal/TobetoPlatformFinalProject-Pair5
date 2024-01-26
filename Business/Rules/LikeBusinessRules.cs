using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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

        public Task LikeShouldExistWhenSelected(Like? like)
        {
            if (like == null)
                throw new BusinessException(Messages.LikeNotExists);
            return Task.CompletedTask;
        }

        public async Task LikeIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Like? like = await _likeDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await LikeShouldExistWhenSelected(like);
        }
    }
}
