using Business.Abstracts;
using Business.Dtos.Competence.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencesController : ControllerBase
    {
        ICompetenceService _competenceService;

        public CompetencesController(ICompetenceService competenceService)
        {
            _competenceService = competenceService;
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] CreateCompetenceRequest createCompetenceRequest)
        {
            var result = await _competenceService.Add(createCompetenceRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteCompetenceRequest deleteCompetenceRequest)
        {
            var result = await _competenceService.Delete(deleteCompetenceRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateCompetenceRequest updateCompetenceRequest)
        {
            var result = await _competenceService.Update(updateCompetenceRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _competenceService.Get(id);
            return Ok(result);

        }

        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _competenceService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("getlistByStudent")]

        public async Task<IActionResult> GetListByStudent([FromQuery] GetListByStudentRequest pageRequest)
        {
            var result = await _competenceService.GetListByStudent(pageRequest);
            return Ok(result);
        }
    }
}
