using Business.Abstracts;
using Business.Dtos.StudentLike.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLikesController : ControllerBase
    {
        IStudentLikeService _studentLikeService;

        public StudentLikesController(IStudentLikeService studentLikeService)
        {
            _studentLikeService = studentLikeService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _studentLikeService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _studentLikeService.GetList(pageRequest);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateStudentLikeRequest createStudentLikeRequest)
        {
            var result = await _studentLikeService.Add(createStudentLikeRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateStudentLikeRequest updateStudentLikeRequest)
        {
            var result = await _studentLikeService.Update(updateStudentLikeRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteStudentLikeRequest deleteStudentLikeRequest)
        {
            var result = await _studentLikeService.Delete(deleteStudentLikeRequest);
            return Ok(result);
        }
    }
}

