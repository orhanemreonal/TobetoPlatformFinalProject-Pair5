using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IClassRoomDal : IRepository<ClassRoom, Guid>, IAsyncRepository<ClassRoom, Guid>
    {
    }
}
