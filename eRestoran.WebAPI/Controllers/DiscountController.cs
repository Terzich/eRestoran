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
    public class DiscountController : BaseCRUDController<Model.Discount, object, Model.Request.DiscountUpsertRequest, Model.Request.DiscountUpsertRequest>
    {
        public DiscountController(ICRUDService<Discount, object, DiscountUpsertRequest, DiscountUpsertRequest> service) : base(service)
        {
        }
    }
}