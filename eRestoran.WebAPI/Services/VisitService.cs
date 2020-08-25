using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class VisitService : BaseCRUDService<Model.Visit, object, Database.Visit, Model.Request.VisitUpsertRequest, Model.Request.VisitUpsertRequest>
    {
        public VisitService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Visit> Get(object search)
        {
            var db = _context.Visit.ToList();
            List<Model.Visit> rez = _mapper.Map<List<Model.Visit>>(db);
            foreach (var item in rez)
            {
                item.VisitorName = _context.User.Find(item.UserId).Name + " " + _context.User.Find(item.UserId).Surname;

            }
            return rez;
        }
    }
}
