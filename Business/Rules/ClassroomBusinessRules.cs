using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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
        public Task CheckIfClassroomNotExist(Classroom? classroom)
        {
            if (classroom == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfClassroomExist(Classroom? classroom)
        {
            if (classroom != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfClassroomNotExist(Guid id)
        {
            Classroom classroom = _classroomDal.Get(a => a.Id == id);
            CheckIfClassroomNotExist(classroom);
        }

    }
}
