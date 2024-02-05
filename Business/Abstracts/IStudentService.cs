using Business.Dtos.Student.Requests;
using Business.Dtos.Student.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IStudentService
    {
        Task<GetStudentResponse> Add(CreateStudentRequest createStudentRequest);
        Task<GetStudentResponse> Update(UpdateStudentRequest updateStudentRequest);
        Task<GetStudentResponse> Delete(DeleteStudentRequest deleteStudentRequest);
        Task<IPaginate<GetListStudentResponse>> GetList(PageRequest pageRequest);
        Task<GetStudentResponse> Get(Guid id);
        Task<GetStudentResponse> GetByUserId(Guid id);

    }
}
