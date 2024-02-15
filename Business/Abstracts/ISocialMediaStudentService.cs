using Business.Dtos.SocialMediaStudent.Requests;
using Business.Dtos.SocialMediaStudent.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISocialMediaStudentService
    {
        Task<GetSocialMediaStudentResponse> Add(CreateSocialMediaStudentRequest createSocialMediaStudentRequest);
        Task<GetSocialMediaStudentResponse> Update(UpdateSocialMediaStudentRequest updateSocialMediaStudentRequest);
        Task<GetSocialMediaStudentResponse> Delete(DeleteSocialMediaStudentRequest deleteSocialMediaStudentRequest);
        Task<IPaginate<GetListSocialMediaStudentResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListSocialMediaStudentResponse>> GetListByUserId(GetSocialMediaStudentByUserIdRequest request);
        Task<IPaginate<GetListSocialMediaStudentResponse>> GetListByStudentId(PageRequest request,Guid id);
        Task<GetSocialMediaStudentResponse> Get(Guid id);
    }
}
