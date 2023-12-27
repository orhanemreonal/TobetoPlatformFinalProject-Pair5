using AutoMapper;
using Business.Abstract;
using Business.Dtos.Auth.Requests;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IMapper _mapper;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginAuthRequest request)
        {


            var userToLogin = await _authService.Login(request);


            var result = _authService.CreateAccessToken(userToLogin);
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterAuthRequest request)
        {
            await  _authService.UserExists(request.Email);


            var registerResult = await _authService.Register(request, request.Password);

            var result = _authService.CreateAccessToken(registerResult);
            if (result != null)
            {
                return Ok(result);
            }

            //return BadRequest(result.Message);
            return Ok(registerResult);
        }
    }
}
