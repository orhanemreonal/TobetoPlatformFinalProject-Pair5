using AutoMapper;
using Business.Dtos.Classroom.Requests;
using Business.Dtos.Classroom.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ClassroomMappingProfile : Profile
    {
        public ClassroomMappingProfile()
        {
            CreateMap<Classroom, CreateClassroomRequest>().ReverseMap();
            CreateMap<Classroom, DeleteClassroomRequest>().ReverseMap();
            CreateMap<Classroom, UpdateClassroomRequest>().ReverseMap();
            CreateMap<GetClassroomResponse, CreateClassroomRequest>().ReverseMap();
            CreateMap<GetClassroomResponse, DeleteClassroomRequest>().ReverseMap();
            CreateMap<GetClassroomResponse, UpdateClassroomRequest>().ReverseMap();


            CreateMap<Classroom, GetClassroomResponse>().ReverseMap();
            CreateMap<Classroom, GetListClassroomResponse>().ReverseMap();
            CreateMap<Paginate<Classroom>, Paginate<GetListClassroomResponse>>().ReverseMap();
        }

    }
}
