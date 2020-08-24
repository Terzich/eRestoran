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
    public class RestaurantReviewController : BaseCRUDController<Model.RestaurantReview, object, Model.Request.RestaurantReviewUpsertRequest, Model.Request.RestaurantReviewUpsertRequest>
    {
        public RestaurantReviewController(ICRUDService<RestaurantReview, object, RestaurantReviewUpsertRequest, RestaurantReviewUpsertRequest> service) : base(service)
        {
        }
    }
}