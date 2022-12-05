using Business.Managers;
using Business.Services;
using Business.Validation;
using Entity.Concrete;
using FluentValidation.Results;
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
    public class BlogController : ControllerBase
    {
        IBlogService bm = new BlogManager();

        [HttpPost("AddBlog")]
        public IActionResult AddBlog(Blog blog)
        {
            //BlogValidator bv = new BlogValidator();
            //ValidationResult validate = bv.Validate(blog);
            //if(Validate.isValid)


            var result = bm.AddBlog(blog);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("DeleteBlog")]
        public IActionResult DeleteBlog(Blog blog)
        {
            var result = bm.DeleteBlog(blog);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("GetBlog")]
        public IActionResult GetBlog(int id)
        {
            var result = bm.GetBlog(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result);
        }

        [HttpGet("GetAllBlog")]
        public IActionResult GetAllBlog()
        {
            var result = bm.GetListBlog();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result);
        }

        [HttpPost("UpdateBlog")]
        public IActionResult UpdateBlog(Blog blog)
        {
            var result = bm.UpdateBlog(blog);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("TopBlog")]
        public IActionResult TopBlog()
        {
            var result = bm.GetTopBlogs();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result);
        }

        [HttpGet("LastBlog")]
        public IActionResult LastBlog()
        {
            var result = bm.GetLastBlogs();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result);
        }

    }
}
