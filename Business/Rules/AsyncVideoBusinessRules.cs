using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class AsyncVideoBusinessRules : BaseBusinessRules
    {
        IAsyncVideoDal _asyncVideoDal;

        public AsyncVideoBusinessRules(IAsyncVideoDal asyncVideoDal)
        {
            _asyncVideoDal = asyncVideoDal;
        }

        public Task AsyncVideoShouldExistWhenSelected(AsyncVideo? asyncVideo)
        {
            if (asyncVideo == null)
                throw new BusinessException(Messages.AsyncVideoNotExists);
            return Task.CompletedTask;
        }

        public async Task AsyncVideoIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            AsyncVideo? asyncVideo = await _asyncVideoDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await AsyncVideoShouldExistWhenSelected(asyncVideo);
        }
    }
}