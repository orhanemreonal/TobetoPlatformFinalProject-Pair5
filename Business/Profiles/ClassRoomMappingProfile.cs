using AutoMapper;
using Business.Dtos.ClassRoom.Requests;
using Business.Dtos.ClassRoom.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ClassRoomMappingProfile : Profile
    {
        public ClassRoomMappingProfile()
        {
            CreateMap<ClassRoom, CreateClassRoomRequest>().ReverseMap();
            CreateMap<ClassRoom, DeleteClassRoomRequest>().ReverseMap();
            CreateMap<ClassRoom, UpdateClassRoomRequest>().ReverseMap();

            CreateMap<ClassRoom, GetClassRoomResponse>().ReverseMap();
            CreateMap<Paginate<ClassRoom>, Paginate<GetListClassRoomResponse>>().ReverseMap();
        }

    }
}
