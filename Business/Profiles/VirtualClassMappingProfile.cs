using AutoMapper;
using Business.Dtos.Course.Responses;
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
            CreateMap<VirtualClass, CreateVirtualClassRequest>().ReverseMap();
            CreateMap<VirtualClass, DeleteVirtualClassRequest>().ReverseMap();
            CreateMap<VirtualClass, UpdateVirtualClassRequest>().ReverseMap();

            CreateMap<GetVirtualClassResponse, UpdateVirtualClassRequest>().ReverseMap();
            CreateMap<GetVirtualClassResponse, CreateVirtualClassRequest>().ReverseMap();
            CreateMap<GetVirtualClassResponse, DeleteVirtualClassRequest>().ReverseMap();


            //Responses
            CreateMap<VirtualClass, GetCourseDetailVirtualClassResponse>().ReverseMap();
            CreateMap<VirtualClass, GetVirtualClassResponse>().ReverseMap();
            CreateMap<VirtualClass, GetListVirtualClassResponse>().ReverseMap();
            CreateMap<Paginate<VirtualClass>, Paginate<GetListVirtualClassResponse>>().ReverseMap();


        }

    }
}
