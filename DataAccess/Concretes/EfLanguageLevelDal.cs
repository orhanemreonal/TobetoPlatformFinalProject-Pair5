using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfLanguageLevelDal : EfRepositoryBase<LanguageLevel, Guid, TobetoPlatformContext>, ILanguageLevelDal
    {
        public EfLanguageLevelDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
