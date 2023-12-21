﻿using AutoMapper;
using Business.Dtos.Experience.Requests;
using Business.Dtos.Experience.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ExperienceMappingProfile : Profile
    {
        public ExperienceMappingProfile()
        {
            //Requests
            CreateMap<Experience, CreateExperienceRequest>().ReverseMap();
            CreateMap<Experience, DeleteExperienceRequest>().ReverseMap();
            CreateMap<Experience, UpdateExperienceRequest>().ReverseMap();


            //Responses
            CreateMap<Experience, GetExperienceResponse>().ReverseMap();
            CreateMap<Paginate<Experience>, Paginate<GetExperienceResponse>>().ReverseMap();
        }
        
    }
}
