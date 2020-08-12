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
    public class RestaurantService : BaseCRUDService<Model.Restaurant,object,Database.Restaurant,Model.Request.RestaurantUpdateRequest, Model.Request.RestaurantUpdateRequest>
    {
        //test
        

        public RestaurantService(eRestoranContext context, IMapper mapper):base(context,mapper)
        {
            
        }
        public override Model.Restaurant GetById(int id)
        {
            var entity = _context.Restaurant.Find(id);
            var result= _mapper.Map<Model.Restaurant>(entity);
            result.CityName = _context.City.Find(entity.CityId).CityName;
            return result;
        }

        public override Model.Restaurant Update(int id, RestaurantUpdateRequest request)
        {
            var entity = _context.Restaurant.Find(id);
            _mapper.Map(request, entity);
            _context.Restaurant.Attach(entity);
            _context.Restaurant.Update(entity);
            _context.SaveChanges();
            var result = _mapper.Map<Model.Restaurant>(entity);
            result.CityName = _context.City.Find(entity.CityId).CityName;
            return result;
        }
    }
}
