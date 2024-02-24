using Business.Abstracts;
using Business.Dtos.Language.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateLanguageRequest createLanguageRequest)
        {
            var result = await _languageService.Add(createLanguageRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _languageService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _languageService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteLanguageRequest deleteLanguageRequest)
        {
            var result = await _languageService.Delete(deleteLanguageRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateLanguageRequest updateLanguageRequest)
        {
            var result = await _languageService.Update(updateLanguageRequest);
            return Ok(result);
        }
    }
}
