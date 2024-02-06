using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISocialMediaStudentDal : IRepository<SocialMediaStudent, Guid>, IAsyncRepository<SocialMediaStudent, Guid>
    {
    }
}
