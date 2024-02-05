using AutoMapper;
using Business.Dtos.LanguageLevel.Requests;
using Business.Dtos.LanguageLevel.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class LanguageLevelMappingProfile : Profile
    {

        public LanguageLevelMappingProfile()
        {
            //Requests
            CreateMap<LanguageLevel, CreateLanguageLevelRequest>().ReverseMap();
            CreateMap<LanguageLevel, DeleteLanguageLevelRequest>().ReverseMap();
            CreateMap<LanguageLevel, UpdateLanguageLevelRequest>().ReverseMap();

            CreateMap<GetLanguageLevelResponse, CreateLanguageLevelRequest>().ReverseMap();
            CreateMap<GetLanguageLevelResponse, DeleteLanguageLevelRequest>().ReverseMap();
            CreateMap<GetLanguageLevelResponse, UpdateLanguageLevelRequest>().ReverseMap();


            //Responses
            CreateMap<LanguageLevel, GetLanguageLevelResponse>().ReverseMap();
            CreateMap<LanguageLevel, GetListLanguageLevelResponse>().ReverseMap();
            CreateMap<Paginate<LanguageLevel>, Paginate<GetListLanguageLevelResponse>>().ReverseMap();
        }

    }
}
