using Business.Abstracts;
using Business.Dtos.Certificate.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        ICertificateService _certificateService;

        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCertificateRequest createCertificateRequest)
        {
            var result = await _certificateService.Add(createCertificateRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _certificateService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _certificateService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(DeleteCertificateRequest deleteCertificateRequest)
        {
            var result = await _certificateService.Delete(deleteCertificateRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateCertificateRequest updateCertificateRequest)
        {
            var result = await _certificateService.Update(updateCertificateRequest);
            return Ok(result);
        }



    }
}
