﻿using AutoMapper;
using Business.Dtos.Language.Requests;
using Business.Dtos.Language.Responses;
using Core.DataAccess.Paging;
using Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class LanguageMappingProfile : Profile
    {

        public LanguageMappingProfile()
        {
            //Requests
            CreateMap<Language, CreateLanguageRequest>().ReverseMap();
            CreateMap<Language, DeleteLanguageRequest>().ReverseMap();
            CreateMap<Language, UpdateLanguageRequest>().ReverseMap();


            //Responses
            CreateMap<Language, GetLanguageResponse>().ReverseMap();
            CreateMap<Paginate<Language>, Paginate<GetLanguageResponse>>().ReverseMap();
        }
       
    }
}
