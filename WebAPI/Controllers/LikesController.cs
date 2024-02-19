using Business.Abstracts;
using Business.Dtos.Like.Requests;
using Core.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikesController : ControllerBase
    {
        ILikeService _likeService;

        public LikesController(ILikeService likeService)
        {
            _likeService = likeService;
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateLikeRequest createLikeRequest)
        {
            var result = await _likeService.Add(createLikeRequest);
            return Ok(result);
        }


        [HttpGet("getlist")]

        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _likeService.GetList(pageRequest);
            return Ok(result);
        }

        [HttpGet("get")]

        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            var result = await _likeService.Get(id);
            return Ok(result);
        }


        [HttpDelete("delete")]

        public async Task<IActionResult> Delete([FromQuery] DeleteLikeRequest deleteLikeRequest)
        {
            var result = await _likeService.Delete(deleteLikeRequest);
            return Ok(result);
        }

        [HttpPut("update")]

        public async Task<IActionResult> Update([FromBody] UpdateLikeRequest updateLikeRequest)
        {
            var result = await _likeService.Update(updateLikeRequest);
            return Ok(result);
        }
    }
}
