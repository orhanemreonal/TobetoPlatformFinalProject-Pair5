using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IStudentLikeDal : IRepository<StudentLike, Guid>, IAsyncRepository<StudentLike, Guid>
    {
    }
}
