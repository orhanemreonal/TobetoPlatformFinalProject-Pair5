using Business.Dtos.PersonelInformations.Requests;
using Business.Dtos.PersonelInformations.Responses;
using Business.Dtos.Users.Requests;
using Business.Dtos.Users.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IPersonalInformationService
    {
        Task<GetPersonalInformationResponse> Add(CreatePersonalInformationRequest createPersonalInformationRequest);
        Task<GetPersonalInformationResponse> Update(UpdatePersonalInformationRequest updatePersonalInformationRequest);
        Task<GetPersonalInformationResponse> Delete(DeletePersonalInformationRequest deletePersonalInformationRequest);
        Task<IPaginate<GetListPersonalInformationResponse>> GetList(PageRequest pageRequest);
        Task<GetPersonalInformationResponse> Get(Guid id);
        Task<GetPersonalInformationResponse> GetByStudentId(Guid id);

    }
}
