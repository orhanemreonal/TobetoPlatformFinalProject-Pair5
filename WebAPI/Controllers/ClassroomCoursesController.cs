using Business.Abstracts;
using Business.Dtos.ClassroomCourse.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomCoursesController : ControllerBase
    {
        IClassroomCourseService _classroomCourseourseService;

        public ClassroomCoursesController(IClassroomCourseService classroomCourseService)
        {
            _classroomCourseourseService = classroomCourseService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateClassroomCourseRequest createClassroomCourseRequest)
        {
            var result = await _classroomCourseourseService.Add(createClassroomCourseRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _classroomCourseourseService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _classroomCourseourseService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(DeleteClassroomCourseRequest deleteClassroomCourseRequest)
        {
            var result = await _classroomCourseourseService.Delete(deleteClassroomCourseRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateClassroomCourseRequest updateClassroomCourseRequest)
        {
            var result = await _classroomCourseourseService.Update(updateClassroomCourseRequest);
            return Ok(result);
        }
    }
}
