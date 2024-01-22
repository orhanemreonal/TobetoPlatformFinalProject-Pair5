using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class CompetenceBusinessRules : BaseBusinessRules
    {
        ICompetenceDal _competenceDal;

        public CompetenceBusinessRules(ICompetenceDal competenceDal)
        {
            _competenceDal = competenceDal;
        }

        public Task CheckIfCompetenceNotExist(Competence? competence)
        {
            if (competence == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfCompetenceExist(Competence? competence)
        {
            if (competence != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfCompetenceNotExist(Guid id)
        {
            Competence competence = _competenceDal.Get(a => a.Id == id);
            CheckIfCompetenceNotExist(competence);
        }
    }
}
