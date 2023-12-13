using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICompetenceDal : IRepository<Competence, Guid>, IAsyncRepository<Competence, Guid>
    {
    }
}
