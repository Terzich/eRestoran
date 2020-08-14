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

    public class SuperOfferController : BaseCRUDController<Model.SuperOffer, Model.Request.SuperOfferSearchRequest, Model.Request.SuperOfferUpsertRequest, Model.Request.SuperOfferUpsertRequest>
    {
        public SuperOfferController(ICRUDService<SuperOffer, SuperOfferSearchRequest, SuperOfferUpsertRequest, SuperOfferUpsertRequest> service) : base(service)
        {
        }
    }
}