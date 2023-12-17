using AutoMapper;
using Business.Dtos.Certificate.Requests;
using Business.Dtos.Certificate.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

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
