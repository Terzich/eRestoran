using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Quantity
    {
        public Quantity()
        {
            RestaurantMenuItem = new HashSet<RestaurantMenuItem>();
        }

        public int QuantityId { get; set; }
        public string Description { get; set; }
        public string Mark { get; set; }

        public virtual ICollection<RestaurantMenuItem> RestaurantMenuItem { get; set; }
    }
}
