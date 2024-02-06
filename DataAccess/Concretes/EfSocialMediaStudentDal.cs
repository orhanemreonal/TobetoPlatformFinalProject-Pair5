using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfSocialMediaStudentDal : EfRepositoryBase<SocialMediaStudent, Guid, TobetoPlatformContext>, ISocialMediaStudentDal
    {
        public EfSocialMediaStudentDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
