using AutoMapper;
using Business.Dtos.ClassAnnouncement.Requests;
using Business.Dtos.ClassAnnouncement.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ClassAnnouncementMappingProfile : Profile
    {
        protected ClassAnnouncementMappingProfile()
        {
            //Requests
            CreateMap<ClassAnnouncement, CreateClassAnnouncementRequest>().ReverseMap();
            CreateMap<ClassAnnouncement, DeleteClassAnnouncementRequest>().ReverseMap();
            CreateMap<ClassAnnouncement, UpdateClassAnnouncementRequest>().ReverseMap();


            //Responses
            CreateMap<ClassAnnouncement, GetClassAnnouncementResponse>().ReverseMap();
            CreateMap<Paginate<ClassAnnouncement>, Paginate<GetClassAnnouncementResponse>>().ReverseMap();
        }
    }
}
