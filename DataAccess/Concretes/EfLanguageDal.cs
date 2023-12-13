using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities;

namespace DataAccess.Concretes
{
    public class EfLanguageDal : EfRepositoryBase<Language, Guid, TobetoPlatformContext>, ILanguageDal
    {
        public EfLanguageDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
