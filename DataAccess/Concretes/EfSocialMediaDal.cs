using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfSocialMediaDal : EfRepositoryBase<SocialMedia, Guid, TobetoPlatformContext>, ISocialMediaDal
    {
        public EfSocialMediaDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
