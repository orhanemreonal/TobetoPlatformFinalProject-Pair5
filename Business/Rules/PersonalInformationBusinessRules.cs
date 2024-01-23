using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class PersonalInformationBusinessRules : BaseBusinessRules
    {
        IPersonalInformationDal _personalInformationDal;

        public PersonalInformationBusinessRules(IPersonalInformationDal personalInformationDal)
        {
            _personalInformationDal = personalInformationDal;
        }

        public Task CheckIfPersonalInformationNotExist(PersonalInformation personalInformation)
        {
            if (personalInformation == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfPersonalInformationExist(PersonalInformation? personalInformation)
        {
            if (personalInformation != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfPersonalInformationNotExist(Guid id)
        {
            PersonalInformation personalInformation = _personalInformationDal.Get(a => a.Id == id);
            CheckIfPersonalInformationNotExist(personalInformation);
        }
    }
}
