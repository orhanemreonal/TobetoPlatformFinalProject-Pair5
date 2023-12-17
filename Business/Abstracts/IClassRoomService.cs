using Business.Dtos.ClassRoom.Requests;
using Business.Dtos.ClassRoom.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IClassRoomService
    {
        Task<GetClassRoomResponse> Add(CreateClassRoomRequest createClassRequest);
        Task<GetClassRoomResponse> Update(UpdateClassRoomRequest updateClassRequest);
        Task<GetClassRoomResponse> Delete(DeleteClassRoomRequest deleteClassRequest);
        Task<IPaginate<GetListClassRoomResponse>> GetList(PageRequest pageRequest);
        Task<GetClassRoomResponse> Get(Guid id);
    }
}
