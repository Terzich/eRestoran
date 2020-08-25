using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class RestaurantUpdateRequest
    {
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public DateTime? OpenAt { get; set; }
        public DateTime? CloseAt { get; set; }
        public int? NumberOfTables { get; set; }
        public int CityId { get; set; }
        public byte[] Image { get; set; }

    }
}
