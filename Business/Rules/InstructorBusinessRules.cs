using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
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
        public Task InstructorShouldExistWhenSelected(Instructor? instructor)
        {
            if (instructor == null)
                throw new BusinessException(Messages.InstructorNotExists);
            return Task.CompletedTask;
        }

        public async Task InstructorIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Instructor? instructor = await _instructorDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await InstructorShouldExistWhenSelected(instructor);
        }
    }
}
