using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Databases;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }
    }
}
