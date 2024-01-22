using AutoMapper;
using Business.Dtos.Title.Requests;
using Business.Dtos.Title.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class TitleMappingProfile : Profile
    {
        public TitleMappingProfile()
        {
            //Requests
            CreateMap<Title,CreateTitleRequest>().ReverseMap();
            CreateMap<Title,DeleteTitleRequest>().ReverseMap();
            CreateMap<Title,UpdateTitleRequest>().ReverseMap();


            //Responses
            CreateMap<Title, GetTitleResponse>().ReverseMap();
            CreateMap<Paginate<Title>, Paginate<GetListTitleResponse>>().ReverseMap();


        }

    }
}
