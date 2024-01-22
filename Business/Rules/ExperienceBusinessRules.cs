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

        public ExperienceBusinessRules(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public Task CheckIfExperienceNotExist(Experience? experience)
        {
            if (experience == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfExperienceExist(Experience? experience)
        {
            if (experience != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfExperienceNotExist(Guid id)
        {
            Experience experience = _experienceDal.Get(a => a.Id == id);
            CheckIfExperienceNotExist(experience);
        }
    }
}
