using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal : IRepository<Category, Guid>, IAsyncRepository<Category, Guid>
    {
    }
}
