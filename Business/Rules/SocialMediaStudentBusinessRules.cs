using Business.Constants;
using Business.Dtos.SocialMediaStudent.Requests;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class SocialMediaStudentBusinessRules : BaseBusinessRules
    {
        ISocialMediaStudentDal _socialMediaStudentDal;
        const int maxMediaAccountCount = 3;

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

        public async Task ControlSocialMediaCountByStudentId(Guid studentId)
        {
            var result = await _socialMediaStudentDal.GetListAsync(predicate: x => x.StudentId == studentId);
            if (result.Count >= maxMediaAccountCount)
            {
                throw new BusinessException($"en fazla {maxMediaAccountCount} adet hesap eklenebilir");
            }
        }

        public async Task SocialMediaStudentAlsoExist(CreateSocialMediaStudentRequest request)
        {
            var result = await _socialMediaStudentDal.GetListAsync(predicate: x => x.StudentId == request.StudentId && x.SocialMediaId == request.SocialMediaId);
            if (result.Count > 0)
            {
                throw new BusinessException(Messages.SocialMediaStudentAlsoExist);
            }
        }
    }
}
