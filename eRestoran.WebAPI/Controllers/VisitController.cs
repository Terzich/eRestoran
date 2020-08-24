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
    public class VisitController : BaseCRUDController<Model.Visit, object, Model.Request.VisitUpsertRequest, Model.Request.VisitUpsertRequest>
    {
        public VisitController(ICRUDService<Visit, object, VisitUpsertRequest, VisitUpsertRequest> service) : base(service)
        {
            
        }
    }
}