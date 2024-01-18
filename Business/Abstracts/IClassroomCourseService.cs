using Business.Dtos.ClassroomCourse.Requests;
using Business.Dtos.ClassroomCourse.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IClassroomCourseService
    {
        Task<GetClassroomCourseResponse> Add(CreateClassroomCourseRequest createClassroomCourseRequest);
        Task<GetClassroomCourseResponse> Update(UpdateClassroomCourseRequest updateClassroomCourseRequest);
        Task<GetClassroomCourseResponse> Delete(DeleteClassroomCourseRequest deleteClassroomCourseRequest);
        Task<IPaginate<GetListClassroomCourseResponse>> GetList(PageRequest pageRequest);
        Task<GetClassroomCourseResponse> Get(Guid id);
    }
}
