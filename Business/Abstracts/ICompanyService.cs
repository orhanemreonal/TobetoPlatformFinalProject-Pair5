using Business.Dtos.Company.Requests;
using Business.Dtos.Company.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICompanyService
    {
        Task<GetCompanyResponse> Add(CreateCompanyRequest createCompanyRequest);
        Task<GetCompanyResponse> Update(UpdateCompanyRequest updateCompanyRequest);
        Task<GetCompanyResponse> Delete(DeleteCompanyRequest deleteCompanyRequest);
        Task<IPaginate<GetListCompanyResponse>> GetList(PageRequest pageRequest);
        Task<GetCompanyResponse> Get(Guid id);
    }
}
