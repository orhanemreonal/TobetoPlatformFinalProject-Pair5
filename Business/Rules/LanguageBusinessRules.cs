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

        public Task CheckIfLanguageNotExist(Language? language)
        {
            if (language == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfLanguageExist(Language? language)
        {
            if (language != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfLanguageNotExist(Guid id)
        {
            Language language = _languageDal.Get(a => a.Id == id);
            CheckIfLanguageNotExist(language);
        }
    }
}
