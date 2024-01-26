using AutoMapper;
using Business.Dtos.Announcement.Requests;
using Business.Dtos.Announcement.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AnnouncementMappingProfile : Profile
    {
        public AnnouncementMappingProfile()
        {
            //Requests
            CreateMap<Announcement, CreateAnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, DeleteAnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, UpdateAnnouncementRequest>().ReverseMap();

            CreateMap<GetAnnouncementResponse, CreateAnnouncementRequest>().ReverseMap();
            CreateMap<GetAnnouncementResponse, UpdateAnnouncementRequest>().ReverseMap();
            CreateMap<GetAnnouncementResponse, DeleteAnnouncementRequest>().ReverseMap();



            //Responses
            CreateMap<Announcement, GetAnnouncementResponse>().ReverseMap();
            CreateMap<Announcement, GetListAnnouncementResponse>().ReverseMap();

            CreateMap<Paginate<Announcement>, Paginate<GetListAnnouncementResponse>>().ReverseMap();
        }

    }
}
