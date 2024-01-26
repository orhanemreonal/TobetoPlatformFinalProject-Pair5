using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Rules
{

    public class ExperienceBusinessRules : BaseBusinessRules
    {
        IExperienceDal _experienceDal;

        public Task ExperienceShouldExistWhenSelected(Experience? experience)
        {
            if (experience == null)
                throw new BusinessException(Messages.ExperienceNotExists);
            return Task.CompletedTask;
        }

        public async Task ExperienceIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Experience? experience = await _experienceDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await ExperienceShouldExistWhenSelected(experience);
        }
    }
}
