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


            CreateMap<StudentLanguage, GetStudentLanguageResponse>().ReverseMap();
            CreateMap<StudentLanguage, GetListStudentLanguageResponse>().ReverseMap();
            CreateMap<Paginate<StudentLanguage>, Paginate<GetListStudentLanguageResponse>>().ReverseMap();

        }


    }
}
