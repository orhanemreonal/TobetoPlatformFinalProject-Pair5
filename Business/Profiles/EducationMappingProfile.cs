using AutoMapper;
using Business.Dtos.Education.Requests;
using Business.Dtos.Education.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class EducationMappingProfile : Profile
    {
        public EducationMappingProfile()
        {
            CreateMap<Education, CreateEducationRequest>().ReverseMap();
            CreateMap<Education, DeleteEducationRequest>().ReverseMap();
            CreateMap<Education, UpdateEducationRequest>().ReverseMap();

            CreateMap<Education, GetEducationResponse>().ReverseMap();
            CreateMap<Education, GetListEducationResponse>().ReverseMap();
            CreateMap<Paginate<Education>, Paginate<GetListEducationResponse>>().ReverseMap();
        }
    }
}
