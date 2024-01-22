using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Certificate.Requests;
using Business.Dtos.Certificate.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;
        IMapper _mapper;
        CertificateBusinessRules _certificateBusinessRules;

        public CertificateManager(ICertificateDal certificateDal, IMapper mapper, CertificateBusinessRules certificateBusinessRules)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;
            _certificateBusinessRules = certificateBusinessRules;
        }

        public async Task<GetCertificateResponse> Add(CreateCertificateRequest request)
        {
            Certificate certificate = _mapper.Map<Certificate>(request);
            await _certificateBusinessRules.CertificateShouldExistWhenSelected(certificate);

            await _certificateDal.AddAsync(certificate);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(request);
            return response;
        }

        public async Task<GetCertificateResponse> Delete(DeleteCertificateRequest request)
        {
            Certificate certificate = await _certificateDal.GetAsync(predicate: c => c.Id == request.Id);

            await _certificateDal.DeleteAsync(certificate);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(certificate);
            return response;
        }

        public async Task<GetCertificateResponse> Get(Guid id)
        {
            Certificate certificate = await _certificateDal.GetAsync(predicate: c => c.Id == id);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(certificate);
            return response;

        }

        public async Task<IPaginate<GetListCertificateResponse>> GetList(PageRequest request)
        {
            var result = await _certificateDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCertificateResponse> response = _mapper.Map<Paginate<GetListCertificateResponse>>(result);
            return response;

        }

        public async Task<GetCertificateResponse> Update(UpdateCertificateRequest request)
        {
            Certificate certificate = _mapper.Map<Certificate>(request);
            await _certificateDal.UpdateAsync(certificate);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(certificate);
            return response;

        }
    }
}
