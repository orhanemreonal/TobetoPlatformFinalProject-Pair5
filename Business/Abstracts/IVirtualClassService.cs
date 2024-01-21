using Business.Dtos.VirtualClass.Requests;
using Business.Dtos.VirtualClass.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IVirtualClassService
    {
        Task<GetVirtualClassResponse> Add(CreateVirtualClassRequest createVirtualClassRequest);
        Task<GetVirtualClassResponse> Update(UpdateVirtualClassRequest updateVirtualClassRequest);
        Task<GetVirtualClassResponse> Delete(DeleteVirtualClassRequest deleteVirtualClassRequest);
        Task<IPaginate<GetListVirtualClassResponse>> GetList(PageRequest pageRequest);
        Task<GetVirtualClassResponse> Get(Guid id);

    }
}
