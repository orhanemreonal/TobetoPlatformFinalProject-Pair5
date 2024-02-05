using Business.Dtos.Experience.Requests;
using Business.Dtos.Experience.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IExperienceService
    {
        Task<GetExperienceResponse> Add(CreateExperienceRequest createExperienceRequest);
        Task<GetExperienceResponse> Update(UpdateExperienceRequest updateExperienceRequest);
        Task<GetExperienceResponse> Delete(DeleteExperienceRequest deleteExperienceRequest);
        Task<IPaginate<GetListExperienceResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListExperienceResponse>> GetListStudentId(PageRequest pageRequest,Guid id);

        Task<GetExperienceResponse> Get(Guid id);
    }
}
