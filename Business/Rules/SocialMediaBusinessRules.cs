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

        public Task CheckIfSocialMediaNotExist(SocialMedia? socialMedia)
        {
            if (socialMedia == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfSocialMediaExist(SocialMedia? socialMedia)
        {
            if (socialMedia != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfSocialMediaNotExist(Guid id)
        {
            SocialMedia socialMedia = _socialMediaDal.Get(a => a.Id == id);
            CheckIfSocialMediaNotExist(socialMedia);
        }
    }
}
