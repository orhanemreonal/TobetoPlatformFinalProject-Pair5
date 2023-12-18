using Business.Dtos.Instructor.Requests;
using Business.Dtos.Instructor.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<GetInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
        Task<GetInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest);
        Task<GetInstructorResponse> Delete(DeleteInstructorRequest deleteInstructorRequest);
        Task<IPaginate<GetListInstructorResponse>> GetList(PageRequest pageRequest);
        Task<GetInstructorResponse> Get(Guid id);
    }
}
