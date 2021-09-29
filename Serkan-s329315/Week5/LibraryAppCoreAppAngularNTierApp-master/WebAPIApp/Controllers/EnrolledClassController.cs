using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API.Models.EnrolledClass;

namespace WEB_API.Controllers
{
    [EnableCors("angular")]
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolledClassController : ControllerBase
    {
        private IEnrolledClass_Service _EnrolledClass_Service;

        public EnrolledClassController(IEnrolledClass_Service EnrolledClass_Service)
        {
            _EnrolledClass_Service = EnrolledClass_Service;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddStudent(string name)
        {
            var result = await _EnrolledClass_Service.AddEnrolledClass(name);
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
        public async Task<IActionResult> GetAllEnrolledClasses()
        {
            var result = await _EnrolledClass_Service.GetAllEnrolledClasses();
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
        public async Task<IActionResult> UpdateEnrolledClass(EnrolledClass_Pass_Object EnrolledClass)
        {
            var result = await _EnrolledClass_Service.UpdateEnrolledClass(EnrolledClass.id, EnrolledClass.name);
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
        public async Task<IActionResult> DeleteEnrolledClass(EnrolledClass_Pass_Object EnrolledClass)
        {
            var result = await _EnrolledClass_Service.DeleteEnrolledClass(EnrolledClass.id);
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
