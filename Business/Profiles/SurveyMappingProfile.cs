using AutoMapper;
using Business.Dtos.Survey.Requests;
using Business.Dtos.Survey.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SurveyMappingProfile : Profile
    {
        public SurveyMappingProfile()
        {
            //Requests
            CreateMap<Survey, CreateSurveyRequest>().ReverseMap();
            CreateMap<Survey, DeleteSurveyRequest>().ReverseMap();
            CreateMap<Survey, UpdateSurveyRequest>().ReverseMap();


            //Responses
            CreateMap<Survey, GetSurveyResponse>().ReverseMap();
            CreateMap<Survey, GetListSurveyResponse>().ReverseMap();
            CreateMap<Paginate<Survey>, Paginate<GetListSurveyResponse>>().ReverseMap();
        }
    }
}
