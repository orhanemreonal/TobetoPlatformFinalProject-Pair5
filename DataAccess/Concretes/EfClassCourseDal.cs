using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfClassCourseDal : EfRepositoryBase<ClassCourse, Guid, TobetoPlatformContext>, IClassCourseDal
    {
        public EfClassCourseDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
