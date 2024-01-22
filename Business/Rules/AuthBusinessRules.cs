//using Business.Abstract;
//using Business.Constants;
//using Core.Business.Rules;
//using Core.CrossCuttingConcerns.Exceptions.Types;

//namespace Business.Rules
//{
//    public class AuthBusinessRules : BaseBusinessRules
//    {
//        IAuthService _authService;

//        public AuthBusinessRules(IAuthService authService)
//        {
//            _authService = authService;
//        }

//        public async Task AuthShouldExistWhenSelected(Auth? auth)
//        {
//            if (auth == null)
//                throw new BusinessException(Messages.AuthNotExists);
//            return Task.CompletedTask;
//        }


//    }
//}
