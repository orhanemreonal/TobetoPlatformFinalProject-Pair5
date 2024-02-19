using Business.Abstracts;
using Business.Dtos.LanguageLevel.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageLevelsController : ControllerBase
    {
        ILanguageLevelService _languageLevelService;

        public LanguageLevelsController(ILanguageLevelService languageLevelService)
        {
            _languageLevelService = languageLevelService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateLanguageLevelRequest createLanguageLevelRequest)
        {
            var result = await _languageLevelService.Add(createLanguageLevelRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _languageLevelService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _languageLevelService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteLanguageLevelRequest deleteLanguageLevelRequest)
        {
            var result = await _languageLevelService.Delete(deleteLanguageLevelRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateLanguageLevelRequest updateLanguageLevelRequest)
        {
            var result = await _languageLevelService.Update(updateLanguageLevelRequest);
            return Ok(result);
        }
    }
}
