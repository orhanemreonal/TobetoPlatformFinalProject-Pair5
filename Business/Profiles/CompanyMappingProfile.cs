using AutoMapper;
using Business.Dtos.Company.Requests;
using Business.Dtos.Company.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CompanyMappingProfile : Profile
    {
        public CompanyMappingProfile()
        {
            CreateMap<Company, CreateCompanyRequest>().ReverseMap();
            CreateMap<Company, DeleteCompanyRequest>().ReverseMap();
            CreateMap<Company, UpdateCompanyRequest>().ReverseMap();
            CreateMap<GetCompanyResponse, CreateCompanyRequest>().ReverseMap();
            CreateMap<GetCompanyResponse, DeleteCompanyRequest>().ReverseMap();
            CreateMap<GetCompanyResponse, UpdateCompanyRequest>().ReverseMap();



            CreateMap<Company, GetCompanyResponse>().ReverseMap();
            CreateMap<Company, GetListCompanyResponse>().ReverseMap();
            CreateMap<Paginate<Company>, Paginate<GetListCompanyResponse>>().ReverseMap();
        }
    }
}
