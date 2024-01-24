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


        public Task UserShouldBeExistsWhenSelected(User? user)
        {
            if (user == null)
                throw new BusinessException(Messages.UserAlreadyExists);
            return Task.CompletedTask;
        }

        public async Task UserIdShouldBeExistsWhenSelected(Guid id)
        {
            bool doesExist = await _userDal.AnyAsync(predicate: u => u.Id == id, enableTracking: false);
            if (doesExist)
                throw new BusinessException(Messages.UserNotBeExist);
        }



        public Task UserPasswordShouldBeMatched(User user, string password)
        {
            if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                throw new BusinessException(Messages.PasswordDontMatch);
            return Task.CompletedTask;
        }

        public async Task UserEmailShouldNotExistsWhenInsert(string email)
        {
            bool doesExists = await _userDal.AnyAsync(predicate: u => u.Email == email, enableTracking: false);
            if (doesExists)
                throw new BusinessException(Messages.UserMailAlreadyExists);
        }

        public async Task UserEmailShouldNotExistsWhenUpdate(Guid id, string email)
        {
            bool doesExists = await _userDal.AnyAsync(predicate: u => u.Id != id && u.Email == email, enableTracking: false);
            if (doesExists)
                throw new BusinessException(Messages.UserMailAlreadyExists);
        }


    }
}
