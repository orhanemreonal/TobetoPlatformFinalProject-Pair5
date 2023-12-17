using Business.Abstracts;
using Business.Dtos.ClassCourse.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassCoursesController : ControllerBase
    {
        IClassCourseService _classCourseourseService;

        public ClassCoursesController(IClassCourseService classCourseService)
        {
            _classCourseourseService = classCourseService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateClassCourseRequest createClassCourseRequest)
        {
            var result = await _classCourseourseService.Add(createClassCourseRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _classCourseourseService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _classCourseourseService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(DeleteClassCourseRequest deleteClassCourseRequest)
        {
            var result = await _classCourseourseService.Delete(deleteClassCourseRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateClassCourseRequest updateClassCourseRequest)
        {
            var result = await _classCourseourseService.Update(updateClassCourseRequest);
            return Ok(result);
        }
    }
}
