using AutoMapper;
using Business.Dtos.Competence.Requests;
using Business.Dtos.Competence.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class CompetenceMappingProfile : Profile
    {
        public CompetenceMappingProfile()
        {

            CreateMap<Competence, CreateCompetenceRequest>().ReverseMap();
            CreateMap<Competence, DeleteCompetenceRequest>().ReverseMap();
            CreateMap<Competence, UpdateCompetenceRequest>().ReverseMap();

            CreateMap<GetCompetenceResponse, CreateCompetenceRequest>().ReverseMap();
            CreateMap<GetCompetenceResponse, DeleteCompetenceRequest>().ReverseMap();
            CreateMap<GetCompetenceResponse, UpdateCompetenceRequest>().ReverseMap();


            CreateMap<Competence, GetCompetenceResponse>().ReverseMap();
            CreateMap<Competence, GetListCompetenceResponse>().ReverseMap();
            CreateMap<Paginate<Competence>, Paginate<GetListCompetenceResponse>>().ReverseMap();
        }
    }
}
