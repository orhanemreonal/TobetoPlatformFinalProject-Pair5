using Business.Dtos.StudentLanguage.Requests;
using Business.Dtos.Students.Requests;
using Business.Dtos.Students.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IStudentLanguageService
    {
        Task<GetStudentLanguageResponse> Add(CreateStudentLanguageRequest createStudentLanguageRequest);
        Task<GetStudentLanguageResponse> Update(UpdateStudentLanguageRequest updateStudentLanguageRequest);
        Task<GetStudentLanguageResponse> Delete(DeleteStudentLanguageRequest deleteStudentLanguageRequest);
        Task<IPaginate<GetListStudentLanguageResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListStudentLanguageResponse>> GetListByStudent(GetStudentLanguagesByStudentRequest pageRequest);
        Task<GetStudentLanguageResponse> Get(Guid id);
    }
}
