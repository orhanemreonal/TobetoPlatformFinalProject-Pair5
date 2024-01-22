using Business.Abstracts;
using Business.Dtos.VirtualClass.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VirtualClassesController : ControllerBase
    {
        IVirtualClassService _virtualClassService;

        public VirtualClassesController(IVirtualClassService virtualClassService)
        {
            _virtualClassService = virtualClassService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateVirtualClassRequest createVirtualClassRequest)
        {
            var result = await _virtualClassService.Add(createVirtualClassRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromBody] PageRequest pageRequest)
        {
            var result = await _virtualClassService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromBody] Guid id)
        {
            var result = await _virtualClassService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteVirtualClassRequest deleteVirtualClassRequest)
        {
            var result = await _virtualClassService.Delete(deleteVirtualClassRequest);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateVirtualClassRequest updateVirtualClassRequest)
        {
            var result = await _virtualClassService.Update(updateVirtualClassRequest);
            return Ok(result);
        }
    }
}
