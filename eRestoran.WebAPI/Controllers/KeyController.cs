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

    public class KeyController : BaseCRUDController<Model.Key, object, Model.Request.KeyUpsertRequest, Model.Request.KeyUpsertRequest>
    {
        public KeyController(ICRUDService<Key, object, KeyUpsertRequest, KeyUpsertRequest> service) : base(service)
        {
        }
    }
}