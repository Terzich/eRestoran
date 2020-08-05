using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class RestaurantUpdateRequest
    {
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public TimeSpan? OpenAt { get; set; }
        public TimeSpan? CloseAt { get; set; }
        public int? NumberOfTables { get; set; }

    }
}
