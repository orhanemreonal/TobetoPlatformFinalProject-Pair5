using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfCategoryDal : EfRepositoryBase<Category, Guid, TobetoPlatformContext>, ICategoryDal
    {
        public EfCategoryDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
