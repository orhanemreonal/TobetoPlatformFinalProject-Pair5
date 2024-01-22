using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IAsyncVideoDal : IRepository<AsyncVideo, Guid>, IAsyncRepository<AsyncVideo, Guid>
    {
    }
}
