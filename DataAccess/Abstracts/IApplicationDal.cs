using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IApplicationDal : IRepository<Application, Guid>, IAsyncRepository<Application, Guid>
    {
    }
}
