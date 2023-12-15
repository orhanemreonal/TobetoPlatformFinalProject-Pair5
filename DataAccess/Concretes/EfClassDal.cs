using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfClassDal : EfRepositoryBase<Class, Guid, TobetoPlatformContext>, IClassDal
    {
        public EfClassDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
