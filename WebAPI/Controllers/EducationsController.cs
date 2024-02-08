using Business.Abstracts;
using Business.Dtos.Education.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _educationService;

        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateEducationRequest createEducationRequest)
        {
            var result = await _educationService.Add(createEducationRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationService.GetList(pageRequest);
            return Ok(result);
        }
        [HttpGet("getliststudentid")]

        public async Task<IActionResult> GetListStudentId([FromQuery] PageRequest pageRequest,Guid id)
        {
            var result = await _educationService.GetListStudentId(pageRequest,id);
            return Ok(result);
        }
        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _educationService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteEducationRequest deleteEducationRequest)
        {
            var result = await _educationService.Delete(deleteEducationRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateEducationRequest updateEducationRequest)
        {
            var result = await _educationService.Update(updateEducationRequest);
            return Ok(result);
        }

    }
}
