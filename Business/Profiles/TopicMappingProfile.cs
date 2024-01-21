using AutoMapper;
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


            //Responses
            CreateMap<Topic,GetTopicResponse>().ReverseMap();
            CreateMap<Paginate<Topic>,Paginate<GetListTopicResponse>>().ReverseMap();

        }

    }
}
