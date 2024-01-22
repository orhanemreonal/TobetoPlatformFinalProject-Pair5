using Business.Dtos.Topic.Requests;
using Business.Dtos.Topic.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ITopicService
    {
        Task<GetTopicResponse> Add(CreateTopicRequest createTopicRequest);
        Task<GetTopicResponse> Update(UpdateTopicRequest updateTopicRequest);
        Task<GetTopicResponse> Delete(DeleteTopicRequest deleteTopicRequest);
        Task<IPaginate<GetListTopicResponse>> GetList(PageRequest pageRequest);
        Task<GetTopicResponse> Get(Guid id);
    }
}
