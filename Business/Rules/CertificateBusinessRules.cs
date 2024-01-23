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


        public Task CheckIfCertificateNotExist(Certificate? certificate)
        {
            if (certificate == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfCertificateExist(Certificate? certificate)
        {
            if (certificate != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfCertificateNotExist(Guid id)
        {
            Certificate certificate = _certificateDal.Get(a => a.Id == id);
            CheckIfCertificateNotExist(certificate);
        }
    }
}
