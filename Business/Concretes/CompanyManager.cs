using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Company.Requests;
using Business.Dtos.Company.Responses;
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

        public CompanyManager(ICompanyDal companyDal, IMapper mapper)
        {
            _companyDal = companyDal;
            _mapper = mapper;
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
            await _companyDal.DeleteAsync(company);
            GetCompanyResponse response = _mapper.Map<GetCompanyResponse>(company);
            return response;
        }

        public async Task<GetCompanyResponse> Get(Guid id)
        {
            Company company = await _companyDal.GetAsync(predicate: cm => cm.Id == id);
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
            Company updatedCompany = _mapper.Map<Company>(request);

            await _companyDal.UpdateAsync(updatedCompany);
            GetCompanyResponse response = _mapper.Map<GetCompanyResponse>(updatedCompany);
            return response;
        }
    }
}
