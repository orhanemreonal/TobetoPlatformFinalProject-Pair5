using Business.Abstracts;
using Business.Dtos.SocialMediaStudent.Requests;
using Business.Rules;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaStudentsController : ControllerBase
    {

        ISocialMediaStudentService _socialMediaStudentService;
        SocialMediaStudentBusinessRules _socialMediaStudentBusinessRules;

        public SocialMediaStudentsController(ISocialMediaStudentService socialMediaStudentService, SocialMediaStudentBusinessRules socialMediaStudentBusinessRules)
        {
            _socialMediaStudentService = socialMediaStudentService;
            _socialMediaStudentBusinessRules = socialMediaStudentBusinessRules;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _socialMediaStudentService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _socialMediaStudentService.GetList(pageRequest);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateSocialMediaStudentRequest createSocialMediaStudentRequest)
        {
            await _socialMediaStudentBusinessRules.ControlSocialMediaCountByStudentId(createSocialMediaStudentRequest.StudentId);
            await _socialMediaStudentBusinessRules.SocialMediaStudentAlsoExist(createSocialMediaStudentRequest);
            var resultAdd = await _socialMediaStudentService.Add(createSocialMediaStudentRequest);
            var resultGet = await _socialMediaStudentService.Get(resultAdd.Id);
            return Ok(resultGet);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateSocialMediaStudentRequest updateSocialMediaStudentRequest)
        {
            var result = await _socialMediaStudentService.Update(updateSocialMediaStudentRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteSocialMediaStudentRequest deleteSocialMediaStudentRequest)
        {
            var result = await _socialMediaStudentService.Delete(deleteSocialMediaStudentRequest);
            return Ok(result);
        }
        [HttpGet("getlistByUserId")]
        public async Task<IActionResult> GetListByUserId([FromQuery] GetSocialMediaStudentByUserIdRequest request)
        {
            var result = await _socialMediaStudentService.GetListByUserId(request);
            return Ok(result);

        }
        [HttpGet("getlistByStudentId")]
        public async Task<IActionResult> GetListByStudentId([FromQuery] PageRequest pageRequest, Guid id)
        {
            var result = await _socialMediaStudentService.GetListByStudentId(pageRequest, id);
            return Ok(result);

        }
    }
}
