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

        public Task CheckIfStudentLanguageNotExist(StudentLanguage? studentLanguage)
        {
            if (studentLanguage == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfStudentLanguageExist(StudentLanguage? studentLanguage)
        {
            if (studentLanguage != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfStudentLanguageNotExist(Guid id)
        {
            StudentLanguage studentLanguage = _studentLanguageDal.Get(a => a.Id == id);
            CheckIfStudentLanguageNotExist(studentLanguage);
        }
    }
}
