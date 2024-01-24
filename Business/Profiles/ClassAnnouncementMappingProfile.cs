using AutoMapper;
using Business.Dtos.ClassAnnouncement.Requests;
using Business.Dtos.ClassAnnouncement.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ClassAnnouncementMappingProfile : Profile
    {
        public ClassAnnouncementMappingProfile()
        {
            //Requests
            CreateMap<ClassAnnouncement, CreateClassAnnouncementRequest>().ReverseMap();
            CreateMap<ClassAnnouncement, DeleteClassAnnouncementRequest>().ReverseMap();
            CreateMap<ClassAnnouncement, UpdateClassAnnouncementRequest>().ReverseMap();
            CreateMap<GetClassAnnouncementResponse, CreateClassAnnouncementRequest>().ReverseMap();
            CreateMap<GetClassAnnouncementResponse, DeleteClassAnnouncementRequest>().ReverseMap();
            CreateMap<GetClassAnnouncementResponse, UpdateClassAnnouncementRequest>().ReverseMap();

            //Responses
            CreateMap<ClassAnnouncement, GetClassAnnouncementResponse>().ReverseMap();
            CreateMap<ClassAnnouncement, GetListClassAnnouncementResponse>().ReverseMap();
            CreateMap<Paginate<ClassAnnouncement>, Paginate<GetListClassAnnouncementResponse>>().ReverseMap();
        }
    }
}
