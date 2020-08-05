using eRestoran.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public interface IRestaurantService
    {
        Model.Restaurant Get(int id);
        Model.Restaurant Update(int id, RestaurantUpdateRequest request);
    }
}
