using Business.Dtos.Classroom.Requests;
using Business.Dtos.Classroom.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IClassroomService
    {
        Task<GetClassroomResponse> Add(CreateClassroomRequest createClassRequest);
        Task<GetClassroomResponse> Update(UpdateClassroomRequest updateClassRequest);
        Task<GetClassroomResponse> Delete(DeleteClassroomRequest deleteClassRequest);
        Task<IPaginate<GetListClassroomResponse>> GetList(PageRequest pageRequest);
        Task<GetClassroomResponse> Get(Guid id);
    }
}
