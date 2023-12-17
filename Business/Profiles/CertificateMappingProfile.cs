using AutoMapper;
using Business.Dtos.Certificate.Requests;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Paging;
using Business.Dtos.Certificate.Responses;

namespace Business.Profiles
{
    public class CertificateMappingProfile : Profile
    {
        public CertificateMappingProfile()
        {
            //Requests
            CreateMap<Certificate, CreateCertificateRequest>().ReverseMap();
            CreateMap<Certificate, DeleteCertificateRequest>().ReverseMap();
            CreateMap<Certificate, UpdateCertificateRequest>().ReverseMap();


            //Responses
            CreateMap<Certificate, GetCertificateResponse>().ReverseMap();
            CreateMap<Paginate<Certificate>, Paginate<GetCertificateResponse>>().ReverseMap();
        }
    }
}
