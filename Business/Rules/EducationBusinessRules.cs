using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class EducationBusinessRules : BaseBusinessRules
    {
        IEducationDal _educationDal;

        public EducationBusinessRules(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public Task CheckIfEducationNotExist(Education? education)
        {
            if (education == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfEducationExist(Education? education)
        {
            if (education != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfEducationNotExist(Guid id)
        {
            Education education = _educationDal.Get(a => a.Id == id);
            CheckIfEducationNotExist(education);
        }
    }
}
