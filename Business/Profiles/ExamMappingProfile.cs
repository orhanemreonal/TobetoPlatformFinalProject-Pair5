﻿using AutoMapper;
using Business.Dtos.Exam.Requests;
using Business.Dtos.Exam.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ExamMappingProfile : Profile
    {
        public ExamMappingProfile()
        {
            CreateMap<Exam, CreateExamRequest>().ReverseMap();
            CreateMap<Exam, DeleteExamRequest>().ReverseMap();
            CreateMap<Exam, UpdateExamRequest>().ReverseMap();

            CreateMap<Exam, GetExamResponse>().ReverseMap();
            CreateMap<Paginate<Exam>, Paginate<GetListExamResponse>>().ReverseMap();
        }
    }
}
