using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class KeyService : BaseCRUDService<Model.Key, object, Database.Key, Model.Request.KeyUpsertRequest, Model.Request.KeyUpsertRequest>
    {
        public KeyService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Key> Get(object search)
        {
            var items = _context.Key.Where(k => k.Active == true).ToList();
            return _mapper.Map<List<Model.Key>>(items);
        }
    }
}
