using AutoMapper;
using Business.Dtos.VirtualClass.Requests;
using Business.Dtos.VirtualClass.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class VirtualClassMappingProfile : Profile
    {
        public VirtualClassMappingProfile()
        {
            //Requests
            CreateMap<VirtualClass,CreateVirtualClassRequest>().ReverseMap();
            CreateMap<VirtualClass,DeleteVirtualClassRequest>().ReverseMap();
            CreateMap<VirtualClass,UpdateVirtualClassRequest>().ReverseMap();


            //Responses
            CreateMap<VirtualClass, GetVirtualClassResponse>().ReverseMap();
            CreateMap<Paginate<VirtualClass>, Paginate<GetListVirtualClassResponse>>().ReverseMap();


        }

    }
}
