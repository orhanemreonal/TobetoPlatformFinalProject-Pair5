using Business.Dtos.Announcement.Requests;
using Business.Dtos.Announcement.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAnnouncementService
    {
        Task<GetAnnouncementResponse> Add(CreateAnnouncementRequest createAnnouncementRequest);
        Task<GetAnnouncementResponse> Update(UpdateAnnouncementRequest updateAnnouncementRequest);
        Task<GetAnnouncementResponse> Delete(DeleteAnnouncementRequest deleteAnnouncementRequest);
        Task<IPaginate<GetListAnnouncementResponse>> GetList(PageRequest pageRequest);
        Task<GetAnnouncementResponse> Get(Guid id);
    }
}
