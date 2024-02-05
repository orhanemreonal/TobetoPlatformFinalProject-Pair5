using Business.Abstracts;
using Business.Dtos.StudentLanguage.Requests;
using Business.Dtos.Students.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLanguagesController : ControllerBase
    {
        IStudentLanguageService _studentLanguageService;

        public StudentLanguagesController(IStudentLanguageService studentLanguageService)
        {
            _studentLanguageService = studentLanguageService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _studentLanguageService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentLanguageService.GetList(pageRequest);
            return Ok(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateStudentLanguageRequest createStudentLanguageRequest)
        {
            var resultAdd = await _studentLanguageService.Add(createStudentLanguageRequest);
            var resultGet = await _studentLanguageService.Get(resultAdd.Id);
            return Ok(resultGet);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateStudentLanguageRequest updateStudentLanguageRequest)
        {
            var result = await _studentLanguageService.Update(updateStudentLanguageRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteStudentLanguageRequest deleteStudentLanguageRequest)
        {
            var result = await _studentLanguageService.Delete(deleteStudentLanguageRequest);
            return Ok(result);
        }
        [HttpGet("getlistbystudent")]
        public async Task<IActionResult> GetListByStudent([FromQuery] GetStudentLanguagesByStudentRequest request)
        {
            var result = await _studentLanguageService.GetListByStudent(request);
            return Ok(result);

        }
    }
}

