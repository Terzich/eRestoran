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
    public class MenuItemsReviewController : BaseCRUDController<Model.MenuItemsReview, object, Model.Request.MenuItemsReviewUpsertRequest, Model.Request.MenuItemsReviewUpsertRequest>
    {
        public MenuItemsReviewController(ICRUDService<MenuItemsReview, object, MenuItemsReviewUpsertRequest, MenuItemsReviewUpsertRequest> service) : base(service)
        {
        }
    }
}