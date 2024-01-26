using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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

        public Task ExamShouldExistWhenSelected(Exam? exam)
        {
            if (exam == null)
                throw new BusinessException(Messages.ExamNotExists);
            return Task.CompletedTask;
        }

        public async Task ExamIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Exam? exam = await _examDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await ExamShouldExistWhenSelected(exam);
        }

    }
}
