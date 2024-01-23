using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class InstructorBusinessRules : BaseBusinessRules
    {
        IInstructorDal _instructorDal;

        public InstructorBusinessRules(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }



        public Task CheckIfInstructorNotExist(Instructor? instructor)
        {
            if (instructor == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfInstructorExist(Instructor? instructor)
        {
            if (instructor != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfInstructorNotExist(Guid id)
        {
            Instructor instructor = _instructorDal.Get(a => a.Id == id);
            CheckIfInstructorNotExist(instructor);
        }
    }
}
