using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models.Blog;

namespace WEB_API.Controllers
{
    [EnableCors("angular")]
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlog_Service _Blog_Service;

        public BlogController(IBlog_Service Blog_Service)
        {
            _Blog_Service = Blog_Service;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddBlog(string name)
        {
            var result = await _Blog_Service.AddBlog(name);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBlogs()
        {
            var result = await _Blog_Service.GetAllBlogs();
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBlog(Blog_Pass_Object student)
        {
            var result = await _Blog_Service.UpdateBlog(student.id, student.name);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> DeleteBlog(Blog_Pass_Object student)
        {
            var result = await _Blog_Service.DeleteBlog(student.id);
            switch (result.success)
            {
                case true:
                    return Ok(result);

                case false:
                    return StatusCode(500, result);
            }
        }

    }
}
