using AutoMapper;
using Business.Dtos.Course.Responses;
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
            CreateMap<Title, CreateTitleRequest>().ReverseMap();
            CreateMap<Title, DeleteTitleRequest>().ReverseMap();
            CreateMap<Title, UpdateTitleRequest>().ReverseMap();


            CreateMap<GetTitleResponse, CreateTitleRequest>().ReverseMap();
            CreateMap<GetTitleResponse, DeleteTitleRequest>().ReverseMap();
            CreateMap<GetTitleResponse, UpdateTitleRequest>().ReverseMap();


            //Responses
            CreateMap<Title, GetTitleResponse>().ReverseMap();
            CreateMap<Title, GetListTitleResponse>().ReverseMap();
            CreateMap<Title, GetCourseDetailTitleResponse>().ReverseMap();
            CreateMap<Paginate<Title>, Paginate<GetListTitleResponse>>().ReverseMap();


        }

    }
}
