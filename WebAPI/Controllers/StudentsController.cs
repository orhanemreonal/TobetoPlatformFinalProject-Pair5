using Business.Abstracts;
using Business.Dtos.Student.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _studentService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getbyuserid")]
        public async Task<IActionResult> GetByUserId([FromQuery] Guid Id)
        {
            var result = await _studentService.GetByUserId(Id);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentService.GetList(pageRequest);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateStudentRequest createStudentRequest)
        {
            var result = await _studentService.Add(createStudentRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateStudentRequest updateStudentRequest)
        {
            var result = await _studentService.Update(updateStudentRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteStudentRequest deleteStudentRequest)
        {
            var result = await _studentService.Delete(deleteStudentRequest);
            return Ok(result);
        }
    }
}

