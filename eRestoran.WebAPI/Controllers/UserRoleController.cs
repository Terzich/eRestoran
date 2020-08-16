using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRestoran.WebAPI.Controllers
{

    public class UserRoleController : BaseController<Model.VisitorRole, object>
    {
        public UserRoleController(IService<VisitorRole, object> service) : base(service)
        {
        }
    }
}