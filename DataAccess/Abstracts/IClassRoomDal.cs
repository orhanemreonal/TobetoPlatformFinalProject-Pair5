using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IClassroomDal : IRepository<Classroom, Guid>, IAsyncRepository<Classroom, Guid>
    {
    }
}
