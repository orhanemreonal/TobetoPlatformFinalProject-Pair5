using Business.Dtos.StudentLike.Requests;
using Business.Dtos.StudentLike.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IStudentLikeService
    {
        Task<GetStudentLikeResponse> Add(CreateStudentLikeRequest createStudentLikeRequest);
        Task<GetStudentLikeResponse> Update(UpdateStudentLikeRequest updateStudentLikeRequest);
        Task<GetStudentLikeResponse> Delete(DeleteStudentLikeRequest deleteStudentLikeRequest);
        Task<IPaginate<GetListStudentLikeResponse>> GetList(PageRequest pageRequest);
        Task<GetStudentLikeResponse> Get(Guid id);
    }
}
