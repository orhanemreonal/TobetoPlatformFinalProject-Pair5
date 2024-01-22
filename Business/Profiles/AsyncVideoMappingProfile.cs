﻿using AutoMapper;
using Business.Dtos.AsyncVideo.Requests;
using Business.Dtos.AsyncVideo.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AsyncVideoMappingProfile : Profile
    {
        public AsyncVideoMappingProfile()
        {
            //Requests
            CreateMap<AsyncVideo, CreateAsyncVideoRequest>().ReverseMap();
            CreateMap<AsyncVideo, DeleteAsyncVideoRequest>().ReverseMap();
            CreateMap<AsyncVideo, UpdateAsyncVideoRequest>().ReverseMap();


            //Responses
            CreateMap<AsyncVideo, GetAsyncVideoResponse>().ReverseMap();
            CreateMap<Paginate<AsyncVideo>, Paginate<GetAsyncVideoResponse>>().ReverseMap();
        }

    }
}
