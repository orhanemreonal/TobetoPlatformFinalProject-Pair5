using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfClassroomDal : EfRepositoryBase<Classroom, Guid, TobetoPlatformContext>, IClassroomDal
    {
        public EfClassroomDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
