using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IClassCourseDal : IRepository<ClassCourse, Guid>, IAsyncRepository<ClassCourse, Guid>
    {
    }
}
