using Business.Abstracts;
using Business.Dtos.Course.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService educationService)
        {
            _courseService = educationService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
        {
            var result = await _courseService.Add(createCourseRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("getPublicCourseList")]

        public async Task<IActionResult> GetPublicCourseList([FromQuery] PageRequest pageRequest)
        {
            var result = await _courseService.GetPublicCourseList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _courseService.Get(id);
            return Ok(result);
        }

        [HttpGet("getDetail")]
        public async Task<IActionResult> GetDetail([FromQuery] Guid id)
        {
            var result = await _courseService.GetDetail(id);
            return Ok(result);
        }

        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteCourseRequest deleteCourseRequest)
        {
            var result = await _courseService.Delete(deleteCourseRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateCourseRequest updateCourseRequest)
        {
            var result = await _courseService.Update(updateCourseRequest);
            return Ok(result);
        }


    }
}
