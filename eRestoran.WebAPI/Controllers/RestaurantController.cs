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
    public class RestaurantController : BaseCRUDController<Model.Restaurant,object,Model.Request.RestaurantUpdateRequest, Model.Request.RestaurantUpdateRequest>
    {

        public RestaurantController(ICRUDService<Model.Restaurant, object, Model.Request.RestaurantUpdateRequest, Model.Request.RestaurantUpdateRequest> service):base(service)
        {
        }

        

    }
}