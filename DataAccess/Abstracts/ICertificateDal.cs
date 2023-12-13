using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICertificateDal : IRepository<Certificate, Guid>, IAsyncRepository<Certificate, Guid>
    {
    }
}
