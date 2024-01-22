using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ICourseTopicDal : IRepository<CourseTopic, Guid>, IAsyncRepository<CourseTopic, Guid>
    {
    }
}
