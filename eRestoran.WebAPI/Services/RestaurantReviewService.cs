using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class RestaurantReviewService : BaseCRUDService<Model.RestaurantReview, object, Database.RestaurantReview, Model.Request.RestaurantReviewUpsertRequest, Model.Request.RestaurantReviewUpsertRequest>
    {
        public RestaurantReviewService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
