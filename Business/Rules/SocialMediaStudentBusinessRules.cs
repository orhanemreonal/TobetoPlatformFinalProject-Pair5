using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class SocialMediaStudentBusinessRules : BaseBusinessRules
    {
        ISocialMediaStudentDal _socialMediaStudentDal;

        public SocialMediaStudentBusinessRules(ISocialMediaStudentDal socialMediaStudentDal)
        {
            _socialMediaStudentDal = socialMediaStudentDal;
        }

        public Task SocialMediaStudentShouldExistWhenSelected(SocialMediaStudent? socialMediaStudent)
        {
            if (socialMediaStudent == null)
                throw new BusinessException(Messages.SocialMediaStudentNotExists);
            return Task.CompletedTask;
        }

        public async Task SocialMediaStudentIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            SocialMediaStudent? socialMediaStudent = await _socialMediaStudentDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await SocialMediaStudentShouldExistWhenSelected(socialMediaStudent);
        }
    }
}
