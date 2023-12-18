using Business.Dtos.SocialMedias.Requests;
using Business.Dtos.SocialMedias.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISocialMediaService
    {
        Task<GetSocialMediaResponse> Add(CreateSocialMediaRequest createSocialMediaRequest);
        Task<GetSocialMediaResponse> Update(UpdateSocialMediaRequest updateSocialMediaRequest);
        Task<GetSocialMediaResponse> Delete(DeleteSocialMediaRequest deleteSocialMediaRequest);
        Task<IPaginate<GetListSocialMediaResponse>> GetList(PageRequest pageRequest);
        Task<GetSocialMediaResponse> Get(Guid id);
    }
}
