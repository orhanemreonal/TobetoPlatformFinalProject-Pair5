using Business.Dtos.Exam.Requests;
using Business.Dtos.Exam.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IExamService
    {
        Task<GetExamResponse> Add(CreateExamRequest createUserRequest);
        Task<GetExamResponse> Update(UpdateExamRequest updateUserRequest);
        Task<GetExamResponse> Delete(DeleteExamRequest deleteUserRequest);
        Task<IPaginate<GetListExamResponse>> GetList(PageRequest pageRequest);
        Task<GetExamResponse> Get(Guid id);
    }
}
