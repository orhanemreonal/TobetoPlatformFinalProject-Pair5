using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;

namespace Business.Rules
{
    public class CertificateBusinessRules : BaseBusinessRules
    {
        ICertificateDal _certificateDal;
        string[] allowedFileTypes = { "doc", "docx", "pdf" };
        const int maxFileSize = 15728640; //15mb
        public CertificateBusinessRules(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public Task CertificateShouldExistWhenSelected(Certificate? certificate)
        {
            if (certificate == null)
                throw new BusinessException(Messages.CertificateNotExists);
            return Task.CompletedTask;
        }

        public async Task CertificateIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Certificate? certificate = await _certificateDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await CertificateShouldExistWhenSelected(certificate);
        }

        public Task CertificateFileTypeControl(IFormFile formFile)
        {
            if (!allowedFileTypes.Contains(formFile.FileName.Split(".").LastOrDefault()))
            {
                throw new BusinessException("İstenmeyen dosya tipi");
            }
            return Task.CompletedTask;
        }

        public Task CertificateSizeControl(IFormFile formFile)
        {

            if (formFile.Length > maxFileSize)
            {
                throw new BusinessException("Yüksek dosya boyutu");
            }
            return Task.CompletedTask;
        }
    }
}