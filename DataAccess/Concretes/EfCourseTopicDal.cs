using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfCourseTopicDal : EfRepositoryBase<CourseTopic, Guid, TobetoPlatformContext>, ICourseTopicDal
    {
        public EfCourseTopicDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
