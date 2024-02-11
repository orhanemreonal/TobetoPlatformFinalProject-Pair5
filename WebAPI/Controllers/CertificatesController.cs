using Business.Abstracts;
using Business.Dtos.Certificate.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        ICertificateService _certificateService;
        IConfiguration _configuration;

        public CertificatesController(ICertificateService certificateService, IConfiguration configuration)
        {
            _certificateService = certificateService;
            _configuration = configuration;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromForm] UploadCertificateRequest uploadCertificateRequest)
        {
            var uploadedFile = await _certificateService.UploadCertificate(uploadCertificateRequest);

            var result = await _certificateService.Add(uploadedFile);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _certificateService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("getlistByStudentId")]
        public async Task<IActionResult> GetListByStudentId([FromQuery] GetListByStudentIdRequest request)
        {
            var result = await _certificateService.GetListByStudentId(request);
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
