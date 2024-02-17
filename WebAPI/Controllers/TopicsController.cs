using Business.Abstracts;
using Business.Dtos.Topic.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        ITopicService _topicService;

        public TopicsController(ITopicService topicService)
        {
            _topicService = topicService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateTopicRequest createTopicRequest)
        {
            var result = await _topicService.Add(createTopicRequest);
            return Ok(result);
        }

        [HttpGet("getlist")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _topicService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get([FromBody] Guid id)
        {
            var result = await _topicService.Get(id);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteTopicRequest deleteTopicRequest)
        {
            var result = await _topicService.Delete(deleteTopicRequest);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateTopicRequest updateTopicRequest)
        {
            var result = await _topicService.Update(updateTopicRequest);
            return Ok(result);
        }
    }
}
