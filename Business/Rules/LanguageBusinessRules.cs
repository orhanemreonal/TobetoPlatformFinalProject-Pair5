using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities;

namespace Business.Rules
{
    public class LanguageBusinessRules : BaseBusinessRules
    {
        ILanguageDal _languageDal;

        public LanguageBusinessRules(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public Task LanguageShouldExistWhenSelected(Language? language)
        {
            if (language == null)
                throw new BusinessException(Messages.LanguageNotExists);
            return Task.CompletedTask;
        }

        public async Task LanguageIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Language? language = await _languageDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await LanguageShouldExistWhenSelected(language);
        }
    }
}
