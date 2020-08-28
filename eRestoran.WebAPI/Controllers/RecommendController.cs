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
    public class RecommendController : ControllerBase
    {
        public IRecommendService _service { get; set; }

        public RecommendController(IRecommendService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.RestaurantMenuItem> RecommendProduct([FromQuery]RecommendedSearchRequest rmItem)
        {
            return _service.RecommendProduct(rmItem.rmiID);
        }
    }
}