using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfSurveyDal : EfRepositoryBase<Survey, Guid, TobetoPlatformContext>, ISurveyDal
    {
        public EfSurveyDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
