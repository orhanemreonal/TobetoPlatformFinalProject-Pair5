using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ILanguageLevelDal : IRepository<LanguageLevel, Guid>, IAsyncRepository<LanguageLevel, Guid>
    {
    }
}
