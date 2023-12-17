using AutoMapper;
using Business.Abstracts;
using Business.Dtos.PersonelInformations.Responses;
using Business.Dtos.SocialMedias.Requests;
using Business.Dtos.SocialMedias.Responses;
using Business.Dtos.Users.Requests;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        IMapper _mapper;

        public SocialMediaManager(ISocialMediaDal socialMediaDal, IMapper mapper)
        {
            _socialMediaDal = socialMediaDal;
            _mapper = mapper;
        }

        public async Task<GetSocialMediaResponse> Add(CreateSocialMediaRequest createSocialMediaRequest)
        {

            SocialMedia socialMedia = _mapper.Map<SocialMedia>(createSocialMediaRequest);
            await _socialMediaDal.AddAsync(socialMedia);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(socialMedia);
            return response;
        }

        public async Task<GetSocialMediaResponse> Delete(DeleteSocialMediaRequest deleteSocialMediaRequest)
        {
            SocialMedia socialMedia = await _socialMediaDal.GetAsync(predicate: u => u.Id == deleteSocialMediaRequest.Id);
            await _socialMediaDal.DeleteAsync(socialMedia);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(socialMedia);
            return response;
        }

        public async Task<GetSocialMediaResponse> Get(Guid id)
        {
            SocialMedia socialMedia = await _socialMediaDal.GetAsync(predicate: u => u.Id == id);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(socialMedia);
            return response;
        }

        public async Task<IPaginate<GetListSocialMediaResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _socialMediaDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
            Paginate<GetListSocialMediaResponse> response = _mapper.Map<Paginate<GetListSocialMediaResponse>>(result);
            return response;
        }

        public async Task<GetSocialMediaResponse> Update(UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            SocialMedia socialMedia = _mapper.Map<SocialMedia>(updateSocialMediaRequest);
            await _socialMediaDal.UpdateAsync(socialMedia);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(socialMedia);
            return response;
        }
    }
}
