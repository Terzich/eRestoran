using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class VisitService : BaseCRUDService<Model.Visit, object, Database.Visit, Model.Request.VisitUpsertRequest, Model.Request.VisitUpsertRequest>
    {
        public VisitService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
