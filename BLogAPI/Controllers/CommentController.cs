using Business.Managers;
using Business.Services;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        readonly ICommentService cm = new CommentManager();

        [HttpPost("AddComment")]
        public IActionResult AddComment(Comment comment)
        {
            var result = cm.AddComment(comment);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("DeleteComment")]
        public IActionResult DeleteComment(Comment comment)
        {
            var result = cm.DeleteComment(comment);
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("GetComment")]
        public IActionResult GetComment(int id)
        {
            var result = cm.GetComment(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("GetAllComment")]
        public IActionResult GetAllComment()
        {
            var result = cm.GetListComment();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("UpdateComment")]
        public IActionResult UpdateComment(Comment comment)
        {
            var result = cm.UpdateComment(comment);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("CommentByBlogID")]
        public IActionResult CommentsByBlogID(int id)
        {
            var result = cm.GetCommentByBlogID(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("CommentsByUserID")]
        public IActionResult CommentsByUserID(int id)
        {
            var result = cm.GetCommentByUserID(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }


    }
}
