using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IUserDal : IRepository<User, Guid>, IAsyncRepository<User, Guid>
    {
    }
}
