using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class LanguageLevelBusinessRules : BaseBusinessRules
    {
        ILanguageLevelDal _languageLevelDal;

        public LanguageLevelBusinessRules(ILanguageLevelDal languageLevelDal)
        {
            _languageLevelDal = languageLevelDal;
        }

        public Task LanguageLevelShouldExistWhenSelected(LanguageLevel? languageLevel)
        {
            if (languageLevel == null)
                throw new BusinessException(Messages.LanguageLevelNotExists);
            return Task.CompletedTask;
        }

        public async Task LanguageLevelIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            LanguageLevel? languageLevel = await _languageLevelDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await LanguageLevelShouldExistWhenSelected(languageLevel);
        }
    }

}
