using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class StudentLikeBusinessRules : BaseBusinessRules

    {
        IStudentLikeDal _studentLikeDal;

        public StudentLikeBusinessRules(IStudentLikeDal studentLikeDal)
        {
            _studentLikeDal = studentLikeDal;
        }
        public Task StudentLikeShouldExistWhenSelected(StudentLike? studentLike)
        {
            if (studentLike == null)
                throw new BusinessException(Messages.StudentLikeNotExists);
            return Task.CompletedTask;
        }

        public async Task StudentLikeIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            StudentLike? studentLike = await _studentLikeDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await StudentLikeShouldExistWhenSelected(studentLike);
        }
    }
}
