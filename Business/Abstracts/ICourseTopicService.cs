using Business.Dtos.CourseTopic.Requests;
using Business.Dtos.CourseTopic.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICourseTopicService
    {
        Task<GetCourseTopicResponse> Add(CreateCourseTopicRequest request);
        Task<GetCourseTopicResponse> Update(UpdateCourseTopicRequest request);
        Task<GetCourseTopicResponse> Delete(DeleteCourseTopicRequest request);
        Task<IPaginate<GetListCourseTopicResponse>> GetList(PageRequest request);
        Task<GetCourseTopicResponse> Get(Guid id);
    }
}
