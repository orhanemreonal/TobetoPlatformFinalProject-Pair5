using AutoMapper;
using Business.Dtos.SocialMedias.Requests;
using Business.Dtos.SocialMedias.Responses;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {
            CreateMap<SocialMedia, CreateSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, DeleteSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaRequest>().ReverseMap();

            CreateMap<SocialMedia, GetSocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, GetListSocialMediaResponse>().ReverseMap();
            CreateMap<Paginate<SocialMedia>, Paginate<GetListSocialMediaResponse>>().ReverseMap();
        }

    }
}
