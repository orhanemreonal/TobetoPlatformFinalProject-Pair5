using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfPersonalInformationDal : EfRepositoryBase<PersonalInformation, Guid, TobetoPlatformContext>, IPersonalInformationDal
    {
        public EfPersonalInformationDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
