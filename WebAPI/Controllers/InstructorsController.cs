using Business.Abstracts;
using Business.Dtos.Instructor.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest createInstructorRequest)
        {
            var result = await _instructorService.Add(createInstructorRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _instructorService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _instructorService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteInstructorRequest deleteInstructorRequest)
        {
            var result = await _instructorService.Delete(deleteInstructorRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateInstructorRequest updateInstructorRequest)
        {
            var result = await _instructorService.Update(updateInstructorRequest);
            return Ok(result);
        }
    }
}
