using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public TimeSpan? OpenAt { get; set; }
        public TimeSpan? CloseAt { get; set; }
        public int? NumberOfTables { get; set; }
        public string ImageUrl { get; set; }

        public virtual City City { get; set; }
    }
}
