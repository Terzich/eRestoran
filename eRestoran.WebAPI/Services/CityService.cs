using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class CityService : BaseService<Model.City, object, Database.City>
    {
        public CityService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
