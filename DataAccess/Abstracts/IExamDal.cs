using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IExamDal : IRepository<Exam, Guid>, IAsyncRepository<Exam, Guid>
    {
    }
}
