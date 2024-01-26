using AutoMapper;
using Business.Dtos.SocialMedias.Requests;
using Business.Dtos.SocialMedias.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {
            CreateMap<SocialMedia, CreateSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, DeleteSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaRequest>().ReverseMap();
            CreateMap<GetSocialMediaResponse, CreateSocialMediaRequest>().ReverseMap();
            CreateMap<GetSocialMediaResponse, UpdateSocialMediaRequest>().ReverseMap();
            CreateMap<GetSocialMediaResponse, DeleteSocialMediaRequest>().ReverseMap();

            CreateMap<SocialMedia, GetSocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, GetListSocialMediaResponse>().ReverseMap();
            CreateMap<Paginate<SocialMedia>, Paginate<GetListSocialMediaResponse>>().ReverseMap();
        }

    }
}
