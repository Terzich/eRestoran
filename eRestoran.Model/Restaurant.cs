using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public DateTime? OpenAt { get; set; }
        public DateTime? CloseAt { get; set; }
        public int? NumberOfTables { get; set; }
        public string CityName { get; set; }

    }
}
