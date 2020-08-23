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
    public class VisitorRecommendationController : BaseCRUDController<Model.VisitorRecommendation, object, Model.Request.VisitorRecommendationUpsertRequest, Model.Request.VisitorRecommendationUpsertRequest>
    {
        public VisitorRecommendationController(ICRUDService<VisitorRecommendation, object, VisitorRecommendationUpsertRequest, VisitorRecommendationUpsertRequest> service) : base(service)
        {
        }
    }
}