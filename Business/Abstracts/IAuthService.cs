using Business.Dtos.Auth.Requests;
using Business.Dtos.Auth.Responses;
using Core.Utilities.Security.Jwt;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<RegisterAuthResponse> Register(RegisterAuthRequest registerAuthRequest, string password);
        Task<LoginAuthResponse> Login(LoginAuthRequest loginAuthRequest);
        //Task UserExists(string email);
        AccessToken CreateAccessToken(LoginAuthResponse loginAuthResponse);
    }
}