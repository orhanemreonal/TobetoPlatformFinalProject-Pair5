using Business.Abstracts;
using Business.Dtos.SocialMedias.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {

        ISocialMediaService _socialMediaService;

        public SocialMediasController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _socialMediaService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _socialMediaService.GetList(pageRequest);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaRequest createSocialMediaRequest)
        {
            var result = await _socialMediaService.Add(createSocialMediaRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateSocialMediaRequest updateSocialMediaRequest)
        {
            var result = await _socialMediaService.Update(updateSocialMediaRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteSocialMediaRequest deleteSocialMediaRequest)
        {
            var result = await _socialMediaService.Delete(deleteSocialMediaRequest);
            return Ok(result);
        }
    }
}
