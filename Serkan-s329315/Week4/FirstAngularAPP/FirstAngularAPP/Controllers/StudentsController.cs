using FirstAngularAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAngularAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            List<Student> oStudents = new List<Student>() {
                new Student() { Id = 1, Name = "Student1", Roll = 1001 },
                new Student() { Id = 2, Name = "Student2", Roll = 1002 },
                new Student() { Id = 3, Name = "Student3", Roll = 1003 } 
            };


            return oStudents;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}", Name ="Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
