using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class RestaurantReviewService : BaseCRUDService<Model.RestaurantReview, object, Database.RestaurantReview, Model.Request.RestaurantReviewUpsertRequest, Model.Request.RestaurantReviewUpsertRequest>
    {
        public RestaurantReviewService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.RestaurantReview> Get(object search)
        {
            var db = _context.RestaurantReview.ToList();
            List<Model.RestaurantReview> rez = _mapper.Map<List<Model.RestaurantReview>>(db);
            foreach (var item in rez)
            {
                item.VisitorName = _context.User.Find(item.UserId).Name + " " + _context.User.Find(item.UserId).Surname;

            }
            return rez;
        }
    }
}
