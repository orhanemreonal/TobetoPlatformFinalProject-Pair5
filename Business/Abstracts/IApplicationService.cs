using Business.Dtos.Application.Requests;
using Business.Dtos.Application.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        Task<GetApplicationResponse> Add(CreateApplicationRequest createApplicationRequest);
        Task<GetApplicationResponse> Update(UpdateApplicationRequest updateApplicationRequest);
        Task<GetApplicationResponse> Delete(DeleteApplicationRequest deleteApplicationRequest);
        Task<IPaginate<GetListApplicationResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListApplicationResponse>> GetListByStudentId(PageRequest pageRequest,Guid id);

        Task<GetApplicationResponse> Get(Guid id);
    }
}
