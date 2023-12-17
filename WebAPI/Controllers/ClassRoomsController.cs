using Business.Abstracts;
using Business.Dtos.ClassRoom.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomsController : ControllerBase
    {
        IClassRoomService _classRoomService;

        public ClassRoomsController(IClassRoomService classRoomService)
        {
            _classRoomService = classRoomService;
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] CreateClassRoomRequest createClassRoomRequest)
        {
            var result = await _classRoomService.Add(createClassRoomRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]

        public async Task<IActionResult> Delete(DeleteClassRoomRequest deleteClassRoomRequest)
        {
            var result = await _classRoomService.Delete(deleteClassRoomRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateClassRoomRequest updateClassRoomRequest)
        {
            var result = await _classRoomService.Update(updateClassRoomRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _classRoomService.Get(id);
            return Ok(result);

        }

        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _classRoomService.GetList(pageRequest);
            return Ok(result);
        }

    }
}
