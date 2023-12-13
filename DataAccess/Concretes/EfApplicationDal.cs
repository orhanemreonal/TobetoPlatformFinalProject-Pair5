using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfApplicationDal : EfRepositoryBase<Application, Guid, TobetoPlatformContext>, IApplicationDal
    {
        public EfApplicationDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
