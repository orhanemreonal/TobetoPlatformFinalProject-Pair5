using AutoMapper;
using Business.Dtos.ClassroomCourse.Requests;
using Business.Dtos.ClassroomCourse.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ClassroomCourseMappingProfile : Profile
    {
        public ClassroomCourseMappingProfile()
        {
            //Requests
            CreateMap<ClassroomCourse, CreateClassroomCourseRequest>().ReverseMap();
            CreateMap<ClassroomCourse, DeleteClassroomCourseRequest>().ReverseMap();
            CreateMap<ClassroomCourse, UpdateClassroomCourseRequest>().ReverseMap();
            CreateMap<GetClassroomCourseResponse, CreateClassroomCourseRequest>().ReverseMap();
            CreateMap<GetClassroomCourseResponse, DeleteClassroomCourseRequest>().ReverseMap();
            CreateMap<GetClassroomCourseResponse, UpdateClassroomCourseRequest>().ReverseMap();


            //Responses
            CreateMap<ClassroomCourse, GetClassroomCourseResponse>().ReverseMap();
            CreateMap<ClassroomCourse, GetListClassroomCourseResponse>().ReverseMap();
            CreateMap<Paginate<ClassroomCourse>, Paginate<GetListClassroomCourseResponse>>().ReverseMap();
        }
    }
}
