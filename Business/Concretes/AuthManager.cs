using AutoMapper;
using Business.Abstract;
using Business.Abstracts;
using Business.Constants;
using Business.Dtos.Auth.Requests;
using Business.Dtos.Users.Requests;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IMapper mapper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(UserRequestValidator))]

        public async Task<User> Register(RegisterAuthRequest request, string password)
        {
            User user = _mapper.Map<User>(request);

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            CreateUserRequest createUserRequest = _mapper.Map<CreateUserRequest>(user);

            var response = await _userService.Add(createUserRequest);

            return _mapper.Map<User>(response);



        }


        public async Task<User> Login(LoginAuthRequest request)
        {
            User user = _mapper.Map<User>(request);
            var loginuser = await _userService.GetByMail(user.Email);

            if (loginuser == null)
            {

                throw new BusinessException(Messages.MailOrPasswordIncorrect);


            }

            if (!HashingHelper.VerifyPasswordHash(request.Password, loginuser.PasswordHash, loginuser.PasswordSalt))
            {
                throw new BusinessException(Messages.MailOrPasswordIncorrect);
            }

            var userResponse = _mapper.Map<User>(loginuser);

            return userResponse;
        }

        public Task UserExists(string email)
        {
            var getByMailResult = _userService.GetByMail(email);
            if (getByMailResult.Result != null)
            {

                throw new BusinessException(Messages.UserAlreadyExists);
            }
            return Task.CompletedTask;
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {

            var claims = await _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);

            return accessToken;
        }

    }
}
