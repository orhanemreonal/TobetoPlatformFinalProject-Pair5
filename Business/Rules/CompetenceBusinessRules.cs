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

        public Task CompetenceShouldExistWhenSelected(Competence? competence)
        {
            if (competence == null)
                throw new BusinessException(Messages.CompetenceNotExists);
            return Task.CompletedTask;
        }

        public async Task CompetenceIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Competence? competence = await _competenceDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await CompetenceShouldExistWhenSelected(competence);
        }
    }
}
