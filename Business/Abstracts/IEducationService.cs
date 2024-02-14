using Business.Dtos.Education.Requests;
using Business.Dtos.Education.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IEducationService
    {
        Task<GetEducationResponse> Add(CreateEducationRequest createUserRequest);
        Task<GetEducationResponse> Update(UpdateEducationRequest updateUserRequest);
        Task<GetEducationResponse> Delete(DeleteEducationRequest deleteUserRequest);
        Task<IPaginate<GetListEducationResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListEducationResponse>> GetListStudentId(PageRequest pageRequest,Guid id);
        Task<GetEducationResponse> Get(Guid id);
    }
}
