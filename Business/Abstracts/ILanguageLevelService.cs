using Business.Dtos.LanguageLevel.Requests;
using Business.Dtos.LanguageLevel.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ILanguageLevelService
    {
        Task<GetLanguageLevelResponse> Add(CreateLanguageLevelRequest createLanguageLevelRequest);
        Task<GetLanguageLevelResponse> Update(UpdateLanguageLevelRequest updateLanguageLevelRequest);
        Task<GetLanguageLevelResponse> Delete(DeleteLanguageLevelRequest deleteLanguageLevelRequest);
        Task<IPaginate<GetListLanguageLevelResponse>> GetList(PageRequest pageRequest);
        Task<GetLanguageLevelResponse> Get(Guid id);
    }
}
