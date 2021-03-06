﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public ActionResult<List<Model.Visitor>> Get([FromQuery]UserSearchRequest search)
        {
            return _service.Get(search);
        }
        
        [HttpGet("{userId}")]
        [Authorize]
        public ActionResult<Model.Visitor> Get(int userId)
        {
            return _service.Get(userId);
        }

        [HttpPost]
        public ActionResult<Model.Visitor>Insert(UserInsertRequest request)
        {
            return _service.Insert(request);
        }
       
        [HttpPut("{id}")]
        [Authorize]
        public ActionResult<Model.Visitor> Update(int id, UserInsertRequest request)
        {
            return _service.Update(id,request);
        }

    }
}