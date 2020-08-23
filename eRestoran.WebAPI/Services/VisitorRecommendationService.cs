using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class VisitorRecommendationService : BaseCRUDService<Model.VisitorRecommendation, object, Database.VisitorRecommendation, Model.Request.VisitorRecommendationUpsertRequest, Model.Request.VisitorRecommendationUpsertRequest>
    {
        public VisitorRecommendationService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
