using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IStudentLanguageDal : IRepository<StudentLanguage, Guid>, IAsyncRepository<StudentLanguage, Guid>
    {
    }
}
