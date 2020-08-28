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
    public class RestaurantMenuItemService : BaseCRUDService<Model.RestaurantMenuItem, Model.Request.MenuItemSearchRequest, Database.RestaurantMenuItem, Model.Request.RestaurantMenuItemUpsertRequest, Model.Request.RestaurantMenuItemUpsertRequest>
    {
        public RestaurantMenuItemService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.RestaurantMenuItem> Get(MenuItemSearchRequest search)
        {
            var query = _context.Set<Database.RestaurantMenuItem>().AsQueryable();
            if(search?.ItemCategoryId.HasValue == true)
            {
                if(search.ItemCategoryId!=-1)
                    query = query.Where(q => q.ItemCategoryId == search.ItemCategoryId);
            }
            query.OrderBy(q => q.ItemName);
            var list = query.ToList();

            var result= _mapper.Map<List<Model.RestaurantMenuItem>>(list);
            
            foreach (var r in result)
            {
                if (r.ItemCategoryId != null)
                    r.ItemCategoryName = _context.ItemCategory.Find(r.ItemCategoryId).Category;
                if (r.QuantityId != null)
                    r.QuantityName = _context.Quantity.Find(r.QuantityId).Description;
            }
            return result;
        }
        public override Model.RestaurantMenuItem GetById(int id)
        {
            var r = _context.RestaurantMenuItem.Find(id);
            var result = _mapper.Map<Model.RestaurantMenuItem>(r);
           
            if (result.ItemCategoryId != null)
                result.ItemCategoryName = _context.ItemCategory.Find(result.ItemCategoryId).Category;
            if (result.QuantityId != null)
                result.QuantityName = _context.Quantity.Find(result.QuantityId).Description;
            
            return result;
        }
    }
}
