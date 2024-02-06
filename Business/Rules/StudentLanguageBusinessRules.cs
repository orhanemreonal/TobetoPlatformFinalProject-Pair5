using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{

    public class StudentLanguageBusinessRules : BaseBusinessRules
    {
        IStudentLanguageDal _studentLanguageDal;

        public StudentLanguageBusinessRules(IStudentLanguageDal studentLanguageDal)
        {
            _studentLanguageDal = studentLanguageDal;
        }

        public Task StudentLanguageShouldExistWhenSelected(StudentLanguage? studentLanguage)
        {
            if (studentLanguage == null)
                throw new BusinessException(Messages.StudentLanguageNotExists);
            return Task.CompletedTask;
        }

        public async Task StudentLanguageIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            StudentLanguage? studentLanguage = await _studentLanguageDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await StudentLanguageShouldExistWhenSelected(studentLanguage);
        }

    }
}
