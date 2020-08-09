using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{

    public class RestaurantMenuItemController : BaseCRUDController<Model.RestaurantMenuItem, Model.Request.MenuItemSearchRequest,Model.Request.RestaurantMenuItemUpsertRequest, Model.Request.RestaurantMenuItemUpsertRequest>
    {
        public RestaurantMenuItemController(ICRUDService<RestaurantMenuItem, MenuItemSearchRequest, Model.Request.RestaurantMenuItemUpsertRequest, Model.Request.RestaurantMenuItemUpsertRequest> service) : base(service)
        {
        }
    }
}