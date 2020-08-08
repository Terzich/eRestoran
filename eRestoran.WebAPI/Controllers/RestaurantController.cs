using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Restaurant> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPut("{id}")]
        public ActionResult<Model.Restaurant> Update(int id,[FromBody] RestaurantUpdateRequest request)
        {
            return _service.Update(id,request);
        }

    }
}