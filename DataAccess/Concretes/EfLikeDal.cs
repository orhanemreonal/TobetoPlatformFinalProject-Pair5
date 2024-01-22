using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfLikeDal : EfRepositoryBase<Like, Guid, TobetoPlatformContext>, ILikeDal
    {
        public EfLikeDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
