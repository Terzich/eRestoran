using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{
    public class ItemCategoryController : BaseController<Model.ItemCategory,object>
    {
        public ItemCategoryController(IService<Model.ItemCategory, object> service) : base(service)
        {
        }
    }
}