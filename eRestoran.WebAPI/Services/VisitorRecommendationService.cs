using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class VisitorRecommendationService : BaseCRUDService<Model.VisitorRecommendation, object, Database.VisitorRecommendation, Model.Request.VisitorRecommendationUpsertRequest, Model.Request.VisitorRecommendationUpsertRequest>
    {
        public VisitorRecommendationService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.VisitorRecommendation> Get(object search)
        {
            var objs = _context.VisitorRecommendation.ToList();
            List<Model.VisitorRecommendation> rez = _mapper.Map<List<Model.VisitorRecommendation>>(objs);
            foreach (var item in rez)
            {
                item.VisitorName=_context.User.Find(item.UserId).Name+" "+ _context.User.Find(item.UserId).Surname;
            }
            return rez;
        }
    }
}
