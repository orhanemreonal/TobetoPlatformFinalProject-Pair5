using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfUserDal : EfRepositoryBase<User, Guid, TobetoPlatformContext>, IUserDal
    {
        public EfUserDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
