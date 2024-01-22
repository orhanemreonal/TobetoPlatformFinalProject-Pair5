using Business.Dtos.Like.Requests;
using Business.Dtos.Like.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ILikeService
    {
        Task<GetLikeResponse> Add(CreateLikeRequest createLikeRequest);
        Task<GetLikeResponse> Update(UpdateLikeRequest updateLikeRequest);
        Task<GetLikeResponse> Delete(DeleteLikeRequest deleteLikeRequest);
        Task<IPaginate<GetListLikeResponse>> GetList(PageRequest pageRequest);
        Task<GetLikeResponse> Get(Guid id);
    }
}
