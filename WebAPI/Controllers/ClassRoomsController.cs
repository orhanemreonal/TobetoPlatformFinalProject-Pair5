using Business.Abstracts;
using Business.Dtos.Classroom.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomsController : ControllerBase
    {
        IClassroomService _classroomService;

        public ClassroomsController(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] CreateClassroomRequest createClassroomRequest)
        {
            var result = await _classroomService.Add(createClassroomRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(DeleteClassroomRequest deleteClassroomRequest)
        {
            var result = await _classroomService.Delete(deleteClassroomRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateClassroomRequest updateClassroomRequest)
        {
            var result = await _classroomService.Update(updateClassroomRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _classroomService.Get(id);
            return Ok(result);

        }

        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _classroomService.GetList(pageRequest);
            return Ok(result);
        }

    }
}
