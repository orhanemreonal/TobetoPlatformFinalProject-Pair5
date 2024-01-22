using Business.Abstracts;
using Business.Dtos.Title.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        ITitleService _titleService;

        public TitlesController(ITitleService titleService)
        {
            _titleService = titleService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateTitleRequest createTitleRequest)
        {
            var result = await _titleService.Add(createTitleRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromBody] PageRequest pageRequest)
        {
            var result = await _titleService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromBody] Guid id)
        {
            var result = await _titleService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteTitleRequest deleteTitleRequest)
        {
            var result = await _titleService.Delete(deleteTitleRequest);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateTitleRequest updateTitleRequest)
        {
            var result = await _titleService.Update(updateTitleRequest);
            return Ok(result);
        }

    }
}
