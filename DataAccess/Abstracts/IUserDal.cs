using Core.DataAccess.Repositories;
using Core.Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IUserDal : IRepository<User, Guid>, IAsyncRepository<User, Guid>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
