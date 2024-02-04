using Business.Dtos.Competence.Requests;
using Business.Dtos.Competence.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICompetenceService
    {
        Task<GetCompetenceResponse> Add(CreateCompetenceRequest createCompetenceRequest);
        Task<GetCompetenceResponse> Update(UpdateCompetenceRequest updateCompetenceRequest);
        Task<GetCompetenceResponse> Delete(DeleteCompetenceRequest deleteCompetenceRequest);
        Task<IPaginate<GetListCompetenceResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListCompetenceResponse>> GetListByStudent(GetListByStudentRequest getListByStudentRequest);
        Task<GetCompetenceResponse> Get(Guid id);
    }
}
