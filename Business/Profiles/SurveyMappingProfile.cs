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

            CreateMap<GetSurveyResponse, UpdateSurveyRequest>().ReverseMap();
            CreateMap<GetSurveyResponse, DeleteSurveyRequest>().ReverseMap();
            CreateMap<GetSurveyResponse, CreateSurveyRequest>().ReverseMap();


            //Responses
            CreateMap<Survey, GetSurveyResponse>().ReverseMap();
            CreateMap<Survey, GetListSurveyResponse>().ReverseMap();
            CreateMap<Paginate<Survey>, Paginate<GetListSurveyResponse>>().ReverseMap();
        }
    }
}
