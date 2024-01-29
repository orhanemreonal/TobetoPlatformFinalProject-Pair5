using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Rules
{
    public class EducationBusinessRules : BaseBusinessRules
    {
        IEducationDal _educationDal;

        public EducationBusinessRules(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public Task EducationShouldExistWhenSelected(Education? education)
        {
            if (education == null)
            {
                throw new BusinessException(Messages.EducationNotExists);
            }
            return Task.CompletedTask;
        }

        public async Task EducationIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Education? education = await _educationDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await EducationShouldExistWhenSelected(education);
        }
    }
}
