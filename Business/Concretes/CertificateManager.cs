    using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Certificate.Requests;
using Business.Dtos.Certificate.Responses;
using Business.Rules;
using Core.Business.Requests;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.Extensions.Configuration;

namespace Business.Concretes
{
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;
        IMapper _mapper;
        IConfiguration _configuration;
        CertificateBusinessRules _businessRules;

        public CertificateManager(ICertificateDal certificateDal, IMapper mapper, CertificateBusinessRules businessRules, IConfiguration configuration)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;
            _businessRules = businessRules;
            _configuration = configuration;
        }


        public async Task<GetCertificateResponse> Add(CreateCertificateRequest request)
        {
            Certificate certificate = _mapper.Map<Certificate>(request);
            await _certificateDal.AddAsync(certificate);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(certificate);
            return response;
        }

        public async Task<GetCertificateResponse> Delete(DeleteCertificateRequest request)
        {
            Certificate certificate = await _certificateDal.GetAsync(predicate: c => c.Id == request.Id);
            await _businessRules.CertificateShouldExistWhenSelected(certificate);
            await _certificateDal.DeleteAsync(certificate);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(certificate);
            return response;
        }

        public async Task<GetCertificateResponse> Get(Guid id)
        {
            Certificate certificate = await _certificateDal.GetAsync(predicate: c => c.Id == id);
            await _businessRules.CertificateShouldExistWhenSelected(certificate);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(certificate);
            return response;
        }

        public async Task<IPaginate<GetListCertificateResponse>> GetList(PageRequest request)
        {
            var result = await _certificateDal.GetListAsync(index: request.Index, size: request.Size);
            Paginate<GetListCertificateResponse> response = _mapper.Map<Paginate<GetListCertificateResponse>>(result);
            return response;
        }

        public async Task<IPaginate<GetListCertificateResponse>> GetListByStudentId(GetListByStudentIdRequest request)
        {
            var result = await _certificateDal.GetListAsync(index: request.Index, size: request.Size, predicate: x => x.StudentId == request.StudentId);
            Paginate<GetListCertificateResponse> response = _mapper.Map<Paginate<GetListCertificateResponse>>(result);
            return response;

        }

        public async Task<GetCertificateResponse> Update(UpdateCertificateRequest request)
        {
            var result = await _certificateDal.GetAsync(predicate: a => a.Id == request.Id);
            _mapper.Map(request, result);
            await _businessRules.CertificateShouldExistWhenSelected(result);
            await _certificateDal.UpdateAsync(result);
            GetCertificateResponse response = _mapper.Map<GetCertificateResponse>(result);
            return response;
        }

        public async Task<CreateCertificateRequest> UploadCertificate(UploadCertificateRequest uploadCertificateRequest)
        {
            CreateCertificateRequest createCertificateRequest = new CreateCertificateRequest();
            //TODO: Bu kural BusinessRule içerisine taşınıp ordan yönetilebilir
            if (uploadCertificateRequest == null || uploadCertificateRequest.File == null)
            {
                throw new BusinessException("PDF file is required.");
            }
            var uploadsFolderPath = _configuration.GetValue<string>("React:FileUploadUrl");
            createCertificateRequest.StudentId = uploadCertificateRequest.StudentId;
            createCertificateRequest.FileExtension = "." + uploadCertificateRequest.File.FileName.Split('.').LastOrDefault();
            createCertificateRequest.FileName = uploadCertificateRequest.File.FileName;
            createCertificateRequest.FilePath = Path.Combine(uploadsFolderPath, Guid.NewGuid().ToString() + createCertificateRequest.FileExtension);

            using (var fileStream = new FileStream(createCertificateRequest.FilePath, FileMode.Create))
            {
                await uploadCertificateRequest.File.CopyToAsync(fileStream);
            }

            //TODO: File extension istenmeyen formattaysa businessRule ile hata dönülmeli

            return createCertificateRequest;

        }
    }
}
