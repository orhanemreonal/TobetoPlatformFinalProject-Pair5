using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfCompanyDal : EfRepositoryBase<Company, Guid, TobetoPlatformContext>, ICompanyDal
    {
        public EfCompanyDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
