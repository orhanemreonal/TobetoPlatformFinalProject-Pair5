using AutoMapper;
using Business.Abstracts;
using Business.BusinessAspects.Autofac;
using Business.Dtos.Company.Requests;
using Business.Dtos.Company.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        IMapper _mapper;
        CompanyBusinessRules _businessRules;

        public CompanyManager(ICompanyDal companyDal, IMapper mapper, CompanyBusinessRules businessRules)
        {
            _companyDal = companyDal;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<GetCompanyResponse> Add(CreateCompanyRequest request)
        {
            Company company = _mapper.Map<Company>(request);

            await _companyDal.AddAsync(company);

            GetCompanyResponse response = _mapper.Map<GetCompanyResponse>(company);
            return response;
        }

        public async Task<GetCompanyResponse> Delete(DeleteCompanyRequest request)
        {
            Company company = await _companyDal.GetAsync(predicate: c => c.Id == request.Id);

            //await _businessRules.CompanyShouldExistWhenSelected(company);
            await _companyDal.DeleteAsync(company);
            GetCompanyResponse response = _mapper.Map<GetCompanyResponse>(company);
            return response;
        }

        public async Task<GetCompanyResponse> Get(Guid id)
        {
            Company company = await _companyDal.GetAsync(predicate: cm => cm.Id == id);

            await _businessRules.CompanyShouldExistWhenSelected(company);
            GetCompanyResponse response = _mapper.Map<GetCompanyResponse>(company);
            return response;
        }

        public async Task<IPaginate<GetListCompanyResponse>> GetList(PageRequest request)
        {
            var result = await _companyDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCompanyResponse> response = _mapper.Map<Paginate<GetListCompanyResponse>>(result);
            return response;
        }

        public async Task<GetCompanyResponse> Update(UpdateCompanyRequest request)
        {

            var result = await _companyDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.CompanyShouldExistWhenSelected(result);
            await _companyDal.UpdateAsync(result);
            GetCompanyResponse response = _mapper.Map<GetCompanyResponse>(result);
            return response;




        }
    }
}
