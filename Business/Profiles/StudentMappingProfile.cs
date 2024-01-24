using AutoMapper;
using Business.Dtos.Student.Requests;
using Business.Dtos.Student.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            //Requests
            CreateMap<Student, CreateStudentRequest>().ReverseMap();
            CreateMap<Student, DeleteStudentRequest>().ReverseMap();
            CreateMap<Student, UpdateStudentRequest>().ReverseMap();

            //Responses
            CreateMap<Student, GetStudentResponse>().ReverseMap();
            CreateMap<Student, GetListStudentResponse>().ReverseMap();

            CreateMap<GetStudentResponse, CreateStudentRequest>().ReverseMap();
            CreateMap<GetStudentResponse, DeleteStudentRequest>().ReverseMap();
            CreateMap<GetStudentResponse, UpdateStudentRequest>().ReverseMap();

            CreateMap<Paginate<Student>, Paginate<GetListStudentResponse>>().ReverseMap();
        }
    }
}
