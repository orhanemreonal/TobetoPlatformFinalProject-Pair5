using Business.Dtos.AsyncVideo.Requests;
using Business.Dtos.AsyncVideo.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAsyncVideoService
    {
        Task<GetAsyncVideoResponse> Add(CreateAsyncVideoRequest createAsyncVideoRequest);
        Task<GetAsyncVideoResponse> Update(UpdateAsyncVideoRequest updateAsyncVideoRequest);
        Task<GetAsyncVideoResponse> Delete(DeleteAsyncVideoRequest deleteAsyncVideoRequest);
        Task<IPaginate<GetListAsyncVideoResponse>> GetList(PageRequest pageRequest);
        Task<GetAsyncVideoResponse> Get(Guid id);
    }
}
