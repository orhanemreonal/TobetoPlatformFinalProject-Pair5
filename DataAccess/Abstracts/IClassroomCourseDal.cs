using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IClassroomCourseDal : IRepository<ClassroomCourse, Guid>, IAsyncRepository<ClassroomCourse, Guid>
    {
    }
}
