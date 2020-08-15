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

    public class AwardController : BaseCRUDController<Model.Award, object, Model.Request.AwardUpsertRequest, Model.Request.AwardUpsertRequest>
    {
        public AwardController(ICRUDService<Award, object, AwardUpsertRequest, AwardUpsertRequest> service) : base(service)
        {
        }
    }
}