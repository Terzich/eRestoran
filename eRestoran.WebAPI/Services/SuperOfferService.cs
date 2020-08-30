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
    public class SuperOfferService : BaseCRUDService<Model.SuperOffer, Model.Request.SuperOfferSearchRequest, Database.SuperOffer, Model.Request.SuperOfferUpsertRequest, Model.Request.SuperOfferUpsertRequest>
    {
        public SuperOfferService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.SuperOffer> Get(SuperOfferSearchRequest search)
        {
            var of = _context.SuperOffer.ToList();
            List<Model.SuperOffer> list = _mapper.Map<List<Model.SuperOffer>>(of);
            foreach (var item in list)
            {

                if (item.DiscountType != null)
                    item.DiscountTypeText = _context.DiscountType.Find(item.DiscountType).Description;
            }

            return list;
        }
    }
}
