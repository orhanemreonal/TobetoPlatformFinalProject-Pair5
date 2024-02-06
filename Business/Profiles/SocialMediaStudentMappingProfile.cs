using AutoMapper;
using Business.Dtos.SocialMediaStudent.Requests;
using Business.Dtos.SocialMediaStudent.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SocialMediaStudentMappingProfile : Profile
    {
        public SocialMediaStudentMappingProfile()
        {
            CreateMap<SocialMediaStudent, CreateSocialMediaStudentRequest>().ReverseMap();
            CreateMap<SocialMediaStudent, DeleteSocialMediaStudentRequest>().ReverseMap();
            CreateMap<SocialMediaStudent, UpdateSocialMediaStudentRequest>().ReverseMap();
            CreateMap<GetSocialMediaStudentResponse, CreateSocialMediaStudentRequest>().ReverseMap();
            CreateMap<GetSocialMediaStudentResponse, UpdateSocialMediaStudentRequest>().ReverseMap();
            CreateMap<GetSocialMediaStudentResponse, DeleteSocialMediaStudentRequest>().ReverseMap();
            CreateMap<SocialMediaStudent, GetSocialMediaStudentResponse>()
                .ForMember(dest => dest.SocialMediaName, opt => opt.MapFrom(src => src.SocialMedia.Name))
                .ReverseMap();
            CreateMap<SocialMediaStudent, GetListSocialMediaStudentResponse>()
              .ForMember(dest => dest.SocialMediaName, opt => opt.MapFrom(src => src.SocialMedia.Name))
              .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
              .ReverseMap();
            CreateMap<Paginate<SocialMediaStudent>, Paginate<GetListSocialMediaStudentResponse>>().ReverseMap();
        }
    }
}
