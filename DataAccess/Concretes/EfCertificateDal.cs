using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfCertificateDal : EfRepositoryBase<Certificate, Guid, TobetoPlatformContext>, ICertificateDal
    {
        public EfCertificateDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
