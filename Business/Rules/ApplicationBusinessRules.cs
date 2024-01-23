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


        public Task CheckIfApplicationNotExist(Application? application)
        {
            if (application == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfApplicationExist(Application? application)
        {
            if (application != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfApplicationNotExist(Guid id)
        {
            Application application = _applicationDal.Get(a => a.Id == id);
            CheckIfApplicationNotExist(application);
        }
    }
}
