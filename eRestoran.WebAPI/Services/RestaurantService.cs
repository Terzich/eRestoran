using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class RestaurantService : IRestaurantService
    {
        //test
        private readonly eRestoranContext _context;
        private readonly IMapper _mapper;

        public RestaurantService(eRestoranContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Model.Restaurant Get(int id)
        {
            var entity = _context.Restaurant.Find(id);
            return _mapper.Map<Model.Restaurant>(entity);
        }

        public Model.Restaurant Update(int id, RestaurantUpdateRequest request)
        {
            var entity = _context.Restaurant.Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Restaurant>(entity);
        }
    }
}
