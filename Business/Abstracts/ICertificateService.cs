using Business.Dtos.Certificate.Requests;
using Business.Dtos.Certificate.Responses;
using Business.Dtos.Users.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICertificateService
    {
        Task<GetCertificateResponse> Add(CreateCertificateRequest createCertificateRequest);
        Task<GetCertificateResponse> Update(UpdateCertificateRequest updateCertificateRequest);
        Task<GetCertificateResponse> Delete(DeleteCertificateRequest deleteCertificateRequest);
        Task<IPaginate<GetListCertificateResponse>> GetList(PageRequest pageRequest);
        Task<GetCertificateResponse> Get(Guid id);


    }
}
