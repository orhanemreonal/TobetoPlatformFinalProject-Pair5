using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICompanyDal : IRepository<Company, Guid>, IAsyncRepository<Company, Guid>
    {
    }
}
