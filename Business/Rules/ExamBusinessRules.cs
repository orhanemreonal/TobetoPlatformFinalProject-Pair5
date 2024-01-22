using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class ExamBusinessRules : BaseBusinessRules
    {
        IExamDal _examDal;

        public ExamBusinessRules(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public Task CheckIfExamNotExist(Exam? exam)
        {
            if (exam == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfExamExist(Exam? exam)
        {
            if (exam != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfExamNotExist(Guid id)
        {
            Exam exam = _examDal.Get(a => a.Id == id);
            CheckIfExamNotExist(exam);
        }

    }
}
