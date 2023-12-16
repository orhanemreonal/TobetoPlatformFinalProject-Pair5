using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<GetUserResponse> Add(CreateUserRequest createUserRequest);
        Task<GetUserResponse> Update(UpdateUserRequest updateUserRequest);
        Task<GetUserResponse> Delete(DeleteUserRequest deleteUserRequest);
        Task<IPaginate<GetListUserResponse>> GetList(PageRequest pageRequest);
        Task<GetUserResponse> Get(Guid id);
    }
}
