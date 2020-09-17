using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Key = new HashSet<Key>();
        }

        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public int? NumberOfTables { get; set; }
        public DateTime? OpenAt { get; set; }
        public DateTime? CloseAt { get; set; }
        public byte[] Image { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Key> Key { get; set; }
    }
}
