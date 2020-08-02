using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.User>> Get()
        {
            Thread.Sleep(5000);
            return _service.Get();
        }
        
        [HttpGet("{userId}")]
        public ActionResult<Model.User> Get(int userId)
        {
            return _service.Get(userId);
        }

        [HttpPost]
        public ActionResult<Model.User>Insert(UserInsertRequest request)
        {
            return _service.Insert(request);
        }

    }
}