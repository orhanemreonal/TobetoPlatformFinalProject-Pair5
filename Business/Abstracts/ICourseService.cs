using Business.Dtos.Course.Requests;
using Business.Dtos.Course.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        Task<GetCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task<GetCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
        Task<GetCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest);
        Task<IPaginate<GetListCourseResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListCourseResponse>> GetPublicCourseList(PageRequest pageRequest);
        Task<GetCourseResponse> Get(Guid id);
        Task<GetCourseDetailResponse> GetDetail(Guid id);
    }
}
