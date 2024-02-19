using Business.Abstracts;
using Business.Dtos.Exam.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        IExamService _examService;

        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateExamRequest createExamRequest)
        {
            var result = await _examService.Add(createExamRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _examService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _examService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteExamRequest deleteExamRequest)
        {
            var result = await _examService.Delete(deleteExamRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateExamRequest updateExamRequest)
        {
            var result = await _examService.Update(updateExamRequest);
            return Ok(result);
        }



    }
}
