using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfExamDal : EfRepositoryBase<Exam, Guid, TobetoPlatformContext>, IExamDal
    {
        public EfExamDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
