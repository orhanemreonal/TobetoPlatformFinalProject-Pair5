using AutoMapper;
using Business.Dtos.Application.Requests;
using Business.Dtos.Application.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            //Requests
            CreateMap<Application, CreateApplicationRequest>().ReverseMap();
            CreateMap<Application, DeleteApplicationRequest>().ReverseMap();
            CreateMap<Application, UpdateApplicationRequest>().ReverseMap();
            CreateMap<GetApplicationResponse, CreateApplicationRequest>().ReverseMap();
            CreateMap<GetApplicationResponse, DeleteApplicationRequest>().ReverseMap();
            CreateMap<GetApplicationResponse, UpdateApplicationRequest>().ReverseMap();

            //Responses
            CreateMap<Application, GetApplicationResponse>().ReverseMap();
            CreateMap<Application, GetListApplicationResponse>().ReverseMap();

            CreateMap<Paginate<Application>, Paginate<GetListApplicationResponse>>().ReverseMap();
        }
    }
}
