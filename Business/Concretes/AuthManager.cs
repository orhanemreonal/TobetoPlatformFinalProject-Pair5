using AutoMapper;
using Business.Abstract;
using Business.Abstracts;
using Business.Constants;
using Business.Dtos.Auth.Requests;
using Business.Dtos.Users.Requests;
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

        public async Task<User> Register(RegisterAuthRequest request, string password)
        {
            User user = _mapper.Map<User>(request);

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            CreateUserRequest createUserRequest = _mapper.Map<CreateUserRequest>(user);

            await _userService.Add(createUserRequest);


            return user;


        }

        public async Task<User> Login(LoginAuthRequest request)
        {
            User user = _mapper.Map<User>(request);
            var loginuser = await _userService.GetByMail(user.Email);

            if (loginuser == null)
            {

                throw new BusinessException(Messages.UserNotBeExist);


            }

            if (!HashingHelper.VerifyPasswordHash(request.Password, loginuser.PasswordHash, loginuser.PasswordSalt))
            {
                throw new BusinessException(Messages.PasswordUncorrect);
            }


            return user;
        }

        public Task UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {

                throw new BusinessException(Messages.UserAlreadyExists);
            }
            throw new BusinessException("Başarılı ");
        }

        public async Task<AccessToken> CreateAccessToken(User user)
        {

            var claims = await _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);

            return accessToken;
        }

    }
}
