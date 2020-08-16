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
    public class DiscountService : BaseCRUDService<Model.Discount, object, Database.Discount, Model.Request.DiscountUpsertRequest, Model.Request.DiscountUpsertRequest>
    {
        public DiscountService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Discount> Get(object search)
        {
            var result = _context.Discount.ToList();
            var ret = _mapper.Map<List<Model.Discount>>(result);
            foreach (var r in ret)
            {
                r.VisitorName = _context.User.Find(r.UserId).Name + " " + _context.User.Find(r.UserId).Surname;
                r.DiscountType = _context.DiscountType.Find(r.DiscountTypeId).Description;
            }
            return ret;
        }
    }
}
