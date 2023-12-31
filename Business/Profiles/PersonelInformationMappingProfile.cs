﻿using AutoMapper;
using Business.Dtos.PersonelInformations.Requests;
using Business.Dtos.PersonelInformations.Responses;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class PersonalInformationMappingProfile : Profile
    {
        public PersonalInformationMappingProfile()
        {
            CreateMap< PersonalInformation, CreatePersonalInformationRequest >().ReverseMap();
            CreateMap<PersonalInformation, DeletePersonalInformationRequest>().ReverseMap();
            CreateMap<PersonalInformation, UpdatePersonalInformationRequest>().ReverseMap();

            CreateMap<PersonalInformation, GetPersonalInformationResponse>().ReverseMap();
            CreateMap<Paginate<PersonalInformation>, Paginate<GetListPersonalInformationResponse>>().ReverseMap();
        }
        
    }
}
