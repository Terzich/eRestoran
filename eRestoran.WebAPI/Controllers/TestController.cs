using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Test>> Get()
        {
            var list = new List<Test>()
            {
                new Test()
                {
                    TestID=1,
                    Name="prvi"
                },
                new Test()
                {
                    TestID=2,
                    Name="drugi"
                }
            };
            return list;
        }
        [HttpGet("{id}")]
        public ActionResult<Test> GetById(int id)
        { 
            Test a = new Test
            {
                TestID = id,
                Name = "test"
            };
            return a;

        }


    }
}