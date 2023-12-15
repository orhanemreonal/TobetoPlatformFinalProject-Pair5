using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfStudentLanguageDal : EfRepositoryBase<StudentLanguage, Guid, TobetoPlatformContext>, IStudentLanguageDal
    {
        public EfStudentLanguageDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
