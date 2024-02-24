using AutoMapper;
using Business.Dtos.Course.Responses;
using Business.Dtos.CourseTopic.Requests;
using Business.Dtos.CourseTopic.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CourseTopicMappingProfile : Profile
    {
        public CourseTopicMappingProfile()
        {
            CreateMap<CourseTopic, CreateCourseTopicRequest>().ReverseMap();
            CreateMap<CourseTopic, DeleteCourseTopicRequest>().ReverseMap();
            CreateMap<CourseTopic, UpdateCourseTopicRequest>().ReverseMap();


            CreateMap<GetCourseTopicResponse, CreateCourseTopicRequest>().ReverseMap();
            CreateMap<GetCourseTopicResponse, DeleteCourseTopicRequest>().ReverseMap();
            CreateMap<GetCourseTopicResponse, UpdateCourseTopicRequest>().ReverseMap();

            //Responses
            CreateMap<CourseTopic, GetCourseTopicResponse>().ReverseMap();
            CreateMap<CourseTopic, GetListCourseTopicResponse>().ReverseMap();
            CreateMap<CourseTopic, GetCourseDetailCourseTopicResponse>().ReverseMap();
            CreateMap<Paginate<CourseTopic>, Paginate<GetListCourseTopicResponse>>().ReverseMap();
        }

    }
}
