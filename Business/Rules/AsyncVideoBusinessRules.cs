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


        public Task CheckIfAsyncVideoNotExist(AsyncVideo? asyncVideo)
        {
            if (asyncVideo == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfAsyncVideoExist(AsyncVideo? asyncVideo)
        {
            if (asyncVideo != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfAsyncVideoNotExist(Guid id)
        {
            AsyncVideo asyncVideo = _asyncVideoDal.Get(a => a.Id == id);
            CheckIfAsyncVideoNotExist(asyncVideo);
        }
    }
}

