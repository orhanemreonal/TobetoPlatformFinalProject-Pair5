using Business.Dtos.Survey.Requests;
using Business.Dtos.Survey.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISurveyService
    {
        Task<GetSurveyResponse> Add(CreateSurveyRequest createSurveyRequest);
        Task<GetSurveyResponse> Update(UpdateSurveyRequest updateSurveyRequest);
        Task<GetSurveyResponse> Delete(DeleteSurveyRequest deleteSurveyRequest);
        Task<IPaginate<GetListSurveyResponse>> GetList(PageRequest pageRequest);
        Task<GetSurveyResponse> Get(Guid id);
    }
}
