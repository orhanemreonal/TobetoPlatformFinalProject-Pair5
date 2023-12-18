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


            //Responses
            CreateMap<Application, GetApplicationResponse>().ReverseMap();
            CreateMap<Paginate<Application>, Paginate<GetApplicationResponse>>().ReverseMap();
        }
    }
}
