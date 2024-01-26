using AutoMapper;
using Business.Abstracts;
using Business.Dtos.SocialMedias.Requests;
using Business.Dtos.SocialMedias.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;
        IMapper _mapper;
        SocialMediaBusinessRules _businessRules;

        public SocialMediaManager(ISocialMediaDal socialMediaDal, IMapper mapper, SocialMediaBusinessRules businessRules)
        {
            _socialMediaDal = socialMediaDal;
            _mapper = mapper;
            _businessRules = businessRules;
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

            await _businessRules.SocialMediaShouldExistWhenSelected(socialMedia);

            await _socialMediaDal.DeleteAsync(socialMedia);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(socialMedia);
            return response;
        }

        public async Task<GetSocialMediaResponse> Get(Guid id)
        {
            SocialMedia socialMedia = await _socialMediaDal.GetAsync(predicate: u => u.Id == id);
            await _businessRules.SocialMediaShouldExistWhenSelected(socialMedia);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(socialMedia);
            return response;
        }

        public async Task<IPaginate<GetListSocialMediaResponse>> GetList(PageRequest pageRequest)
        {
            var result = await _socialMediaDal.GetListAsync(index: pageRequest.Index, size: pageRequest.Size);
            Paginate<GetListSocialMediaResponse> response = _mapper.Map<Paginate<GetListSocialMediaResponse>>(result);
            return response;
        }

        public async Task<GetSocialMediaResponse> Update(UpdateSocialMediaRequest request)
        {
            var result = await _socialMediaDal.GetAsync(predicate: a => a.Id == request.Id);
            await _businessRules.SocialMediaShouldExistWhenSelected(result);
            _mapper.Map(request, result);

            await _socialMediaDal.UpdateAsync(result);
            GetSocialMediaResponse response = _mapper.Map<GetSocialMediaResponse>(result);
            return response;

        }
    }
}
