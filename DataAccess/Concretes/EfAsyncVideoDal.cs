using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfAsyncVideoDal : EfRepositoryBase<AsyncVideo, Guid, TobetoPlatformContext>, IAsyncVideoDal
    {
        public EfAsyncVideoDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
