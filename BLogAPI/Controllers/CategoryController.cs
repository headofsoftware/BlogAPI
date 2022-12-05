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
    public class CategoryController : ControllerBase
    {
        ICategoryService cm = new CategoryManager();

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            var result = cm.AddCategory(category);
            if (result.Success)
                return Ok(result);
           return BadRequest(result);
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory(Category category)
        {
            var result = cm.DeleteCategory(category);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var result = cm.GetCategory(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpGet("GetAllCategory")]
        public IActionResult GetAllCategory()
        {
            var result = cm.GetListCategory();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpPost("UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            var result = cm.UpdateCategory(category);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message); ;
        }

        [HttpGet("LastCategories")]
        public IActionResult LastCategories()
        {
            var result = cm.GetLastCategory();
            if(result.Success)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("TopCategories")]
        public IActionResult TopCategories()
        {
            var result = cm.GetTopCategory();
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
