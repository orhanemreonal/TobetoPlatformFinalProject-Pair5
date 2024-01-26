using AutoMapper;
using Business.Dtos.StudentLike.Requests;
using Business.Dtos.StudentLike.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class StudentLikeMappingProfile : Profile
    {
        public StudentLikeMappingProfile()
        {
            //Requests
            CreateMap<StudentLike, CreateStudentLikeRequest>().ReverseMap();
            CreateMap<StudentLike, DeleteStudentLikeRequest>().ReverseMap();
            CreateMap<StudentLike, UpdateStudentLikeRequest>().ReverseMap();

            CreateMap<GetStudentLikeResponse, UpdateStudentLikeRequest>().ReverseMap();
            CreateMap<GetStudentLikeResponse, CreateStudentLikeRequest>().ReverseMap();
            CreateMap<GetStudentLikeResponse, DeleteStudentLikeRequest>().ReverseMap();


            //Responses
            CreateMap<StudentLike, GetStudentLikeResponse>().ReverseMap();
            CreateMap<StudentLike, GetListStudentLikeResponse>().ReverseMap();
            CreateMap<Paginate<StudentLike>, Paginate<GetListStudentLikeResponse>>().ReverseMap();
        }
    }
}
