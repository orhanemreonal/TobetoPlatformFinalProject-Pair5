using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class ClassroomBusinessRules : BaseBusinessRules
    {
        IClassroomDal _classroomDal;

        public ClassroomBusinessRules(IClassroomDal classroomDal)
        {
            _classroomDal = classroomDal;
        }
        public Task ClassroomShouldExistWhenSelected(Classroom? classroom)
        {
            if (classroom == null)
                throw new BusinessException(Messages.ClassroomNotExists);
            return Task.CompletedTask;
        }

        public async Task ClassroomIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Classroom? classroom = await _classroomDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await ClassroomShouldExistWhenSelected(classroom);
        }

    }
}
