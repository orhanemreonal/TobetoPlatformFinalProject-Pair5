using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IPersonalInformationDal : IRepository<PersonalInformation, Guid>, IAsyncRepository<PersonalInformation, Guid>
    {
    }
}
