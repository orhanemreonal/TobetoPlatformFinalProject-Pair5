using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{

    public class ApplicationBusinessRules : BaseBusinessRules
    {
        IApplicationDal _applicationDal;

        public ApplicationBusinessRules(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public Task ApplicationShouldExistWhenSelected(Application? application)
        {
            if (application == null)
                throw new BusinessException(Messages.ApplicationNotExists);
            return Task.CompletedTask;
        }

        public async Task ApplicationIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Application? application = await _applicationDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await ApplicationShouldExistWhenSelected(application);
        }
    }
}
