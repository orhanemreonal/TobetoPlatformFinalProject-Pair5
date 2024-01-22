using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfStudentLikeDal : EfRepositoryBase<StudentLike, Guid, TobetoPlatformContext>, IStudentLikeDal
    {
        public EfStudentLikeDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
