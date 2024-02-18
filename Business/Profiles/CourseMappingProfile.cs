using AutoMapper;
using Business.Dtos.Course.Requests;
using Business.Dtos.Course.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<Course, CreateCourseRequest>().ReverseMap();
            CreateMap<Course, DeleteCourseRequest>().ReverseMap();
            CreateMap<Course, UpdateCourseRequest>().ReverseMap();

            CreateMap<GetCourseResponse, CreateCourseRequest>().ReverseMap();
            CreateMap<GetCourseResponse, DeleteCourseRequest>().ReverseMap();
            CreateMap<GetCourseResponse, UpdateCourseRequest>().ReverseMap();

            CreateMap<Course, GetCourseDetailResponse>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
            CreateMap<Course, GetCourseResponse>()
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name))
             .ReverseMap();
            CreateMap<Course, GetListCourseResponse>()
              .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
              .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name))
              .ReverseMap();
        }
    }
}
