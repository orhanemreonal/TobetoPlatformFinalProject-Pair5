using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISocialMediaDal : IRepository<SocialMedia, Guid>, IAsyncRepository<SocialMedia, Guid>
    {
    }
}
