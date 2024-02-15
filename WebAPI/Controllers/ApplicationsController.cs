using Business.Abstracts;
using Business.Dtos.Application.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid Id)
        {
            var result = await _applicationService.Get(Id);
            return Ok(result);
        }
        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _applicationService.GetList(pageRequest);
            return Ok(result);

        }
        [HttpGet("getlistByStudentId")]
        public async Task<IActionResult> GetListByStudentId([FromQuery] PageRequest pageRequest,Guid id)
        {
            var result = await _applicationService.GetListByStudentId(pageRequest,id);
            return Ok(result);

        }
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateApplicationRequest createApplicationRequest)
        {
            var result = await _applicationService.Add(createApplicationRequest);
            return Ok(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] UpdateApplicationRequest updateApplicationRequest)
        {
            var result = await _applicationService.Update(updateApplicationRequest);
            return Ok(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromQuery] DeleteApplicationRequest deleteApplicationRequest)
        {
            var result = await _applicationService.Delete(deleteApplicationRequest);
            return Ok(result);
        }
    }
}
