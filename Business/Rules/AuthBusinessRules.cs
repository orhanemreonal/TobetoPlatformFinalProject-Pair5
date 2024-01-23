using Business.Abstract;
using Core.Business.Rules;

namespace Business.Rules
{
    public class AuthBusinessRules : BaseBusinessRules
    {
        IAuthService _authService;

        public AuthBusinessRules(IAuthService authService)
        {
            _authService = authService;
        }

        //public Task AuthNotExist(User? user)
        //{
        //    if (user == null) throw new BusinessException(Messages.NotBeExist);
        //    return Task.CompletedTask;

        //}


    }
}
