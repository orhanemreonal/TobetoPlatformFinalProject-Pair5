using Business.Abstracts;
using Business.Dtos.PersonelInformations.Requests;
using Business.Dtos.SocialMedias.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInformationsController : ControllerBase
    {
        IPersonalInformationService _personalInformationService;

        public PersonalInformationsController(IPersonalInformationService personalInformationService)
        {
            _personalInformationService = personalInformationService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _personalInformationService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getList")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _personalInformationService.GetList(pageRequest);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreatePersonalInformationRequest createPersonalInformationRequest)
        {
            var result = await _personalInformationService.Add(createPersonalInformationRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdatePersonalInformationRequest updatePersonalInformationRequest)
        {
            var result = await _personalInformationService.Update(updatePersonalInformationRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeletePersonalInformationRequest deletePersonalInformationRequest)
        {
            var result = await _personalInformationService.Delete(deletePersonalInformationRequest);
            return Ok(result);
        }
    }
}
