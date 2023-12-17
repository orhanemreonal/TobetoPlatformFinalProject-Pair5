using Business.Dtos.ClassAnnouncement.Requests;
using Business.Dtos.ClassAnnouncement.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IClassAnnouncementService
    {
        Task<GetClassAnnouncementResponse> Add(CreateClassAnnouncementRequest createClassAnnouncementRequest);
        Task<GetClassAnnouncementResponse> Update(UpdateClassAnnouncementRequest updateCertificateRequest);
        Task<GetClassAnnouncementResponse> Delete(DeleteClassAnnouncementRequest deleteCertificateRequest);
        Task<IPaginate<GetClassAnnouncementResponse>> GetList(PageRequest pageRequest);
        Task<GetClassAnnouncementResponse> Get(Guid id);
    }
}
