using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ILikeDal : IRepository<Like, Guid>, IAsyncRepository<Like, Guid>
    {
    }
}
