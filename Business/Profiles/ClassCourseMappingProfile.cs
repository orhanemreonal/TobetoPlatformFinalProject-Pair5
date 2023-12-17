using AutoMapper;
using Business.Dtos.ClassCourse.Requests;
using Business.Dtos.ClassCourse.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ClassCourseMappingProfile : Profile
    {
        protected ClassCourseMappingProfile()
        {
            //Requests
            CreateMap<ClassCourse, CreateClassCourseRequest>().ReverseMap();
            CreateMap<ClassCourse, DeleteClassCourseRequest>().ReverseMap();
            CreateMap<ClassCourse, UpdateClassCourseRequest>().ReverseMap();


            //Responses
            CreateMap<ClassCourse, GetClassCourseResponse>().ReverseMap();
            CreateMap<Paginate<ClassCourse>, Paginate<GetClassCourseResponse>>().ReverseMap();
        }
    }
}
