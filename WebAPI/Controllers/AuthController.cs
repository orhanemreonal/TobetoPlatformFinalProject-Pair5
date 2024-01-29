using AutoMapper;
using Business.Abstract;
using Business.Abstracts;
using Business.Dtos.Auth.Requests;
using Business.Dtos.Student.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IMapper _mapper;
        private IStudentService _studentService;
        public AuthController(IAuthService authService,IStudentService studentService)
        {
            _authService = authService;
            _studentService = studentService;
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
        [HttpPost("RegisterStudent")]
        public async Task<IActionResult> RegisterStudent([FromBody] RegisterAuthRequest request)
        {
            await _authService.UserExists(request.Email);

            var registerResult = await _authService.Register(request, request.Password);
            CreateStudentRequest student = new CreateStudentRequest { UserId = registerResult.Id };

            await _studentService.Add(student);
            var result = _authService.CreateAccessToken(registerResult);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
