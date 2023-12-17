using Business.Dtos.ClassCourse.Requests;
using Business.Dtos.ClassCourse.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IClassCourseService
    {
        Task<GetClassCourseResponse> Add(CreateClassCourseRequest createClassCourseRequest);
        Task<GetClassCourseResponse> Update(UpdateClassCourseRequest updateClassCourseRequest);
        Task<GetClassCourseResponse> Delete(DeleteClassCourseRequest deleteClassCourseRequest);
        Task<IPaginate<GetClassCourseResponse>> GetList(PageRequest pageRequest);
        Task<GetClassCourseResponse> Get(Guid id);
    }
}
