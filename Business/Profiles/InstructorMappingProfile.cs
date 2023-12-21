using AutoMapper;
using Business.Dtos.Instructor.Requests;
using Business.Dtos.Instructor.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    internal class InstructorMappingProfile : Profile
    {
        public InstructorMappingProfile()
        {
            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();

            CreateMap<Instructor, GetInstructorResponse>().ReverseMap();
            CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>().ReverseMap();
        }
    }
}
