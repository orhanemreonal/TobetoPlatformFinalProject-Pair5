using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfAnnouncementDal : EfRepositoryBase<Announcement, Guid, TobetoPlatformContext>, IAnnouncementDal
{
    public EfAnnouncementDal(TobetoPlatformContext context) : base(context)
    {
    }
}
