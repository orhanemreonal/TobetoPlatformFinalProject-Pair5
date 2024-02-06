using Business.Abstracts;
using Business.Dtos.Experience.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
        {
            var result = await _experienceService.Add(createExperienceRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _experienceService.GetList(pageRequest);
            return Ok(result);
        }
        [HttpGet("getliststudentid")]

        public async Task<IActionResult> GetListStudentId([FromQuery] PageRequest pageRequest,Guid id)
        {
            var result = await _experienceService.GetListStudentId(pageRequest,id);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _experienceService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteExperienceRequest deleteExperienceRequest)
        {
            var result = await _experienceService.Delete(deleteExperienceRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateExperienceRequest updateExperienceRequest)
        {
            var result = await _experienceService.Update(updateExperienceRequest);
            return Ok(result);
        }
    }
}
