using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IClassDal : IRepository<Class, Guid>, IAsyncRepository<Class, Guid>
    {
    }
}
