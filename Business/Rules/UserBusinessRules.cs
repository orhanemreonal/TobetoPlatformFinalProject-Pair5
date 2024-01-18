using Business.Constants;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class UserBusinessRules : BaseBusinessRules
    {
        IUserDal _userDal;

        public UserBusinessRules(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Task CheckIfUserNotExist(User? user)
        {
            if (user == null) throw new BusinessException(Messages.NotBeExist);
            return Task.CompletedTask;

        }

        public Task CheckIfUserExist(User? user)
        {
            if (user != null) throw new BusinessException(Messages.AlreadyExist);
            return Task.CompletedTask;
        }

        public async Task CheckIdIfUserNotExist(Guid id)
        {
            User user = _userDal.Get(a => a.Id == id);
            CheckIfUserNotExist(user);
        }

        public Task UserPasswordMustBeMatched(User user, string password)
        {
            if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                throw new BusinessException(Messages.PasswordDontMatch);
            return Task.CompletedTask;
        }

        public async Task UserEmailMustBeUnique(string email)
        {
            bool doesExists = await _userDal.AnyAsync(predicate: u => u.Email == email, enableTracking: false);
            if (doesExists)
                throw new BusinessException(Messages.UserMailAlreadyExists);
        }


    }
}
