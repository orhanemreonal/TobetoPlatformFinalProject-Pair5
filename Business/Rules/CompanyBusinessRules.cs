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

        public Task CompanyShouldExistWhenSelected(Company? company)
        {
            if (company == null)
                throw new BusinessException(Messages.CompanyNotExists);
            return Task.CompletedTask;
        }

        public async Task CompanyIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        {
            Company? company = await _companyDal.GetAsync(
                predicate: at => at.Id == id,
                enableTracking: false,
                cancellationToken: cancellationToken
            );
            await CompanyShouldExistWhenSelected(company);
        }
    }
}
