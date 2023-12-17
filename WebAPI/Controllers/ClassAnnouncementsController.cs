using Business.Abstracts;
using Business.Dtos.ClassAnnouncement.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassAnnouncementsController : ControllerBase
    {
        IClassAnnouncementService _classAnnouncementService;

        public ClassAnnouncementsController(IClassAnnouncementService classAnnouncementService)
        {
            _classAnnouncementService = classAnnouncementService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateClassAnnouncementRequest createClassAnnouncementRequest)
        {
            var result = await _classAnnouncementService.Add(createClassAnnouncementRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _classAnnouncementService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _classAnnouncementService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(DeleteClassAnnouncementRequest deleteClassAnnouncementRequest)
        {
            var result = await _classAnnouncementService.Delete(deleteClassAnnouncementRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateClassAnnouncementRequest updateClassAnnouncementRequest)
        {
            var result = await _classAnnouncementService.Update(updateClassAnnouncementRequest);
            return Ok(result);
        }
    }
}
