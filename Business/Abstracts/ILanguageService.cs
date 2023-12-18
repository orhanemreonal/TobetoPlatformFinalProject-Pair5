using Business.Dtos.Language.Requests;
using Business.Dtos.Language.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ILanguageService
    {
        Task<GetLanguageResponse> Add(CreateLanguageRequest createLanguageRequest);
        Task<GetLanguageResponse> Update(UpdateLanguageRequest updateLanguageRequest);
        Task<GetLanguageResponse> Delete(DeleteLanguageRequest deleteLanguageRequest);
        Task<IPaginate<GetListLanguageResponse>> GetList(PageRequest pageRequest);
        Task<GetLanguageResponse> Get(Guid id);
    }
}
