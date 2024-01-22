using Business.Dtos.Category.Requests;
using Business.Dtos.Category.Responses;
using Business.Dtos.Title.Requests;
using Business.Dtos.Title.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ITitleService
    {
        Task<GetTitleResponse> Add(CreateTitleRequest createTitleRequest);
        Task<GetTitleResponse> Update(UpdateTitleRequest updateTitleRequest);
        Task<GetTitleResponse> Delete(DeleteTitleRequest deleteTitleRequest);
        Task<IPaginate<GetListTitleResponse>> GetList(PageRequest pageRequest);
        Task<GetTitleResponse> Get(Guid id);
    }
}
