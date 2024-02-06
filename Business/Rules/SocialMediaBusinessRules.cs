using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class SocialMediaBusinessRules : BaseBusinessRules
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaBusinessRules(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public Task SocialMediaShouldExistWhenSelected(SocialMedia? socialMedia)
        {
            if (socialMedia == null)
                throw new BusinessException(Messages.SocialMediaNotExists);
            return Task.CompletedTask;
        }

        public async Task SocialMediaIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            SocialMedia? socialMedia = await _socialMediaDal.GetAsync(
                predicate: a => a.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await SocialMediaShouldExistWhenSelected(socialMedia);
        }
    }
}
