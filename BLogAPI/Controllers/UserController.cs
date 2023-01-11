using Business.Managers;
using Business.Services;
using Entity.Concrete;
using Entity.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BLogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService cm = new UserManager();

        [HttpPost("AddUser")]
        public IActionResult AddUser(User user)
        {
            var result = cm.AddUser(user);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteUser(User user)
        {
            var result = cm.DeleteUser(user);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }
        [HttpPost("GetUser")]
        public IActionResult GetUser(int id)
        {
            var result = cm.GetUser(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }

        [HttpGet("GetAllUser")]
        public IActionResult GetAllUser()
        {
            var result = cm.GetListUser();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }

        [HttpPost("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            var result = cm.UpdateUser(user);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }

        public IActionResult Login(LoginDTO login)
        {
            var user = cm.Login(login);
            if (user != null)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("username", user.Username, options);


                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Username),
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties()
                {
                    ExpiresUtc = System.DateTimeOffset.UtcNow.AddMinutes(60)
                };

                HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
                );

                return Ok();
            }
            else
                return BadRequest();


        }
    }
}
