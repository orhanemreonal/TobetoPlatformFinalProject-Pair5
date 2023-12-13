using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IAnnouncementDal : IRepository<Announcement, Guid>, IAsyncRepository<Announcement, Guid>
    {
    }
}
