using AutoMapper;
using Business.Dtos.Students.Requests;
using Business.Dtos.Students.Responses;
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
    public class StudentLanguageMappingProfile :Profile
    {
        public StudentLanguageMappingProfile()
        {
            CreateMap<StudentLanguage, CreateStudentLanguageRequest>().ReverseMap();
            CreateMap<StudentLanguage, DeleteStudentLanguageRequest>().ReverseMap();
            CreateMap<StudentLanguage, UpdateStudentLanguageRequest>().ReverseMap();

            CreateMap<StudentLanguage, GetStudentLanguageResponse>().ReverseMap();
            CreateMap<Paginate<StudentLanguage>, Paginate<GetListStudentLanguageResponse>>().ReverseMap();

        }


    }
}
