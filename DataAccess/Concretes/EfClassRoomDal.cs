using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfClassRoomDal : EfRepositoryBase<ClassRoom, Guid, TobetoPlatformContext>, IClassRoomDal
    {
        public EfClassRoomDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
