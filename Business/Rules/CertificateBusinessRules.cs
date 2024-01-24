using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class CertificateBusinessRules : BaseBusinessRules
    {
        ICertificateDal _certificateDal;

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
    }
}