using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.WebAPI.Database;

namespace eRestoran.WebAPI.Services
{
    public class MenuItemsReviewService : BaseCRUDService<Model.MenuItemsReview, object, Database.MenuItemsReview, Model.Request.MenuItemsReviewUpsertRequest, Model.Request.MenuItemsReviewUpsertRequest>
    {
        public MenuItemsReviewService(eRestoranContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
