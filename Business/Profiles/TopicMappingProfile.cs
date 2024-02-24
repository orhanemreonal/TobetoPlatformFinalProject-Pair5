using AutoMapper;
using Business.Dtos.Course.Responses;
using Business.Dtos.Topic.Requests;
using Business.Dtos.Topic.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class TopicMappingProfile : Profile
    {
        public TopicMappingProfile()
        {
            //Requests
            CreateMap<Topic, CreateTopicRequest>().ReverseMap();
            CreateMap<Topic, DeleteTopicRequest>().ReverseMap();
            CreateMap<Topic, UpdateTopicRequest>().ReverseMap();


            CreateMap<GetTopicResponse, UpdateTopicRequest>().ReverseMap();
            CreateMap<GetTopicResponse, CreateTopicRequest>().ReverseMap();
            CreateMap<GetTopicResponse, DeleteTopicRequest>().ReverseMap();


            //Responses
            CreateMap<Topic, GetTopicResponse>().ReverseMap();
            CreateMap<Topic, GetListTopicResponse>().ReverseMap();
            CreateMap<Topic, GetCourseDetailTopicResponse>().ReverseMap();
            CreateMap<Paginate<Topic>, Paginate<GetListTopicResponse>>().ReverseMap();

        }

    }
}
