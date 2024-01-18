using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class ApplicationBusinessRules : BaseBusinessRules
    {
        IApplicationDal _applicationDal;

        public ApplicationBusinessRules(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }
    }
}
