using Business.Dtos.Course.Requests;
using Business.Dtos.Course.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        Task<GetCourseResponse> Add(CreateCourseRequest createUserRequest);
        Task<GetCourseResponse> Update(UpdateCourseRequest updateUserRequest);
        Task<GetCourseResponse> Delete(DeleteCourseRequest deleteUserRequest);
        Task<IPaginate<GetListCourseResponse>> GetList(PageRequest pageRequest);
        Task<GetCourseResponse> Get(Guid id);
    }
}
