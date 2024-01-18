using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfClassroomCourseDal : EfRepositoryBase<ClassroomCourse, Guid, TobetoPlatformContext>, IClassroomCourseDal
    {
        public EfClassroomCourseDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
