using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<User> Add(User user);
    }
}
