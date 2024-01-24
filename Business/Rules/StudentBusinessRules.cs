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

        public async Task CheckIfUserAlreadyStudent(Guid id)
        {
            bool doesExist = await _studentDal.AnyAsync(predicate: u => u.UserId == id, enableTracking: false);
            if (doesExist)
                throw new BusinessException(Messages.StudentAlreadyExits);
        }

        public Task StudentShouldExistWhenSelected(Student? student)
        {
            if (student == null)
                throw new BusinessException(Messages.StudentNotExists);
            return Task.CompletedTask;
        }

        public async Task StudentIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Student? student = await _studentDal.GetAsync(
                predicate: s => s.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await StudentShouldExistWhenSelected(student);
        }
    }
}
