using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class CompanyBusinessRules : BaseBusinessRules
    {
        ICompanyDal _companyDal;

        public CompanyBusinessRules(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public Task CheckIfCompanyNotExist(Company? company)
        {
            if (company == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfCompanyExist(Company? company)
        {
            if (company != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfCompanyNotExist(Guid id)
        {
            Company company = _companyDal.Get(a => a.Id == id);
            CheckIfCompanyNotExist(company);
        }
    }
}
