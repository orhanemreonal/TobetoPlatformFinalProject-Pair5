using Business.Abstract;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class AuthBusinessRules : BaseBusinessRules
    {
        IAuthService _authService;
        IUserDal _userDal;

        public AuthBusinessRules(IAuthService authService, IUserDal _userDal)
        {
            _authService = authService;
            _userDal = _userDal;
        }


        //public Task AuthShouldExistWhenSelected(User? user)
        //{
        //    if (user == null)
        //        throw new BusinessException(Messages.AuthNotExists);
        //    return Task.CompletedTask;
        //}

        //public async Task AuthIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
        //{
        //    User? user = await _userDal.GetAsync(
        //        predicate: at => at.Id == id,
        //        enableTracking: false,
        //        cancellationToken: cancellationToken
        //    );
        //    await AuthShouldExistWhenSelected(user);
        //}

    }
}
