using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class SuperOfferService : BaseCRUDService<Model.SuperOffer, Model.Request.SuperOfferSearchRequest, Database.SuperOffer, Model.Request.SuperOfferUpsertRequest, Model.Request.SuperOfferUpsertRequest>
    {
        public SuperOfferService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
