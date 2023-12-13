using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfExperienceDal : EfRepositoryBase<Experience, Guid, TobetoPlatformContext>, IExperienceDal
    {
        public EfExperienceDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
