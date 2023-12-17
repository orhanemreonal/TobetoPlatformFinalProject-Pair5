using AutoMapper;
using Business.Dtos.ClassCourse.Requests;
using Business.Dtos.ClassCourse.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ClassCourseMappingProfile : Profile
    {
        public ClassCourseMappingProfile()
        {
            //Requests
            CreateMap<ClassCourse, CreateClassCourseRequest>().ReverseMap();
            CreateMap<ClassCourse, DeleteClassCourseRequest>().ReverseMap();
            CreateMap<ClassCourse, UpdateClassCourseRequest>().ReverseMap();


            //Responses
            CreateMap<ClassCourse, GetClassCourseResponse>().ReverseMap();
            CreateMap<Paginate<ClassCourse>, Paginate<GetListClassCourseResponse>>().ReverseMap();
        }
    }
}
