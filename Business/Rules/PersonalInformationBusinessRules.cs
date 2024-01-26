using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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

        public Task PersonalInformationShouldExistWhenSelected(PersonalInformation? personalInformation)
        {
            if (personalInformation == null)
                throw new BusinessException(Messages.PersonalInformationNotExists);
            return Task.CompletedTask;
        }

        public async Task PersonalInformationIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            PersonalInformation? personalInformation = await _personalInformationDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await PersonalInformationShouldExistWhenSelected(personalInformation);
        }
    }
}
