using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eRestoran.WebAPI.Services
{
    public class AwardService : BaseCRUDService<Model.Award, object, Database.Award, Model.Request.AwardUpsertRequest, Model.Request.AwardUpsertRequest>
    {
        public AwardService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Award> Get(object search)
        {
            var result = _context.Award.Include(a => a.User).ToList();
            var resultR = _mapper.Map<List<Model.Award>>(result);
            foreach(var r in resultR)
            {
                r.VisitorName = _context.User.Find(r.UserId).Name + " " + _context.User.Find(r.UserId).Surname;
            }
            return resultR;
        }
    }
}
