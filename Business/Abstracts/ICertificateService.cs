using Business.Dtos.Certificate.Requests;
using Business.Dtos.Certificate.Responses;
using Core.Business.Requests;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICertificateService
    {
        Task<CreateCertificateRequest> UploadCertificate(UploadCertificateRequest uploadCertificateRequest);
        Task<GetCertificateResponse> Add(CreateCertificateRequest createCertificateRequest);
        Task<GetCertificateResponse> Update(UpdateCertificateRequest updateCertificateRequest);
        Task<GetCertificateResponse> Delete(DeleteCertificateRequest deleteCertificateRequest);
        Task<IPaginate<GetListCertificateResponse>> GetList(PageRequest pageRequest);
        Task<IPaginate<GetListCertificateResponse>> GetListByStudentId(GetListByStudentIdRequest pageRequest);
        Task<GetCertificateResponse> Get(Guid id);


    }
}
