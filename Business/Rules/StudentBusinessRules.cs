using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class StudentBusinessRules : BaseBusinessRules
    {
        IStudentDal _studentDal;

        public StudentBusinessRules(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public Task CheckIfStudentNotExist(Student? student)
        {
            if (student == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfStudentExist(Student? student)
        {
            if (student != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfStudentNotExist(Guid id)
        {
            Student student = _studentDal.Get(a => a.Id == id);
            CheckIfStudentNotExist(student);
        }
    }
}
