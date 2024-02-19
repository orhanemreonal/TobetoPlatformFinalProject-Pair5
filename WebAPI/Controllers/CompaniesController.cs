using Business.Abstracts;
using Business.Dtos.Company.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("add")]

        public async Task<IActionResult> Add([FromBody] CreateCompanyRequest createCompanyRequest)
        {
            var result = await _companyService.Add(createCompanyRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteCompanyRequest deleteCompanyRequest)
        {
            var result = await _companyService.Delete(deleteCompanyRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateCompanyRequest updateCompanyRequest)
        {
            var result = await _companyService.Update(updateCompanyRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _companyService.Get(id);
            return Ok(result);

        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _companyService.GetList(pageRequest);
            return Ok(result);

        }

    }
}
