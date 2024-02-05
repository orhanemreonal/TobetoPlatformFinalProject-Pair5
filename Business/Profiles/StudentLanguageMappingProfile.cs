using AutoMapper;
using Business.Dtos.Students.Requests;
using Business.Dtos.Students.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class StudentLanguageMappingProfile : Profile
    {
        public StudentLanguageMappingProfile()
        {
            CreateMap<StudentLanguage, CreateStudentLanguageRequest>().ReverseMap();
            CreateMap<StudentLanguage, DeleteStudentLanguageRequest>().ReverseMap();
            CreateMap<StudentLanguage, UpdateStudentLanguageRequest>().ReverseMap();

            CreateMap<GetStudentLanguageResponse, UpdateStudentLanguageRequest>().ReverseMap();
            CreateMap<GetStudentLanguageResponse, DeleteStudentLanguageRequest>().ReverseMap();
            CreateMap<GetStudentLanguageResponse, CreateStudentLanguageRequest>().ReverseMap();


            CreateMap<StudentLanguage, GetStudentLanguageResponse>()
                .ForMember(dest => dest.LanguageName, opt => opt.MapFrom(src => src.Language.Name))
                .ForMember(dest => dest.LanguageLevel, opt => opt.MapFrom(src => src.LanguageLevel.Level))
                .ReverseMap();
            CreateMap<StudentLanguage, GetListStudentLanguageResponse>()
                .ForMember(dest => dest.LanguageName, opt => opt.MapFrom(src => src.Language.Name))
                .ForMember(dest => dest.LanguageLevel, opt => opt.MapFrom(src => src.LanguageLevel.Level))
                .ReverseMap();
            CreateMap<Paginate<StudentLanguage>, Paginate<GetListStudentLanguageResponse>>().ReverseMap();

        }


    }
}
