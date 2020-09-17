using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Key
    {
        public int KeyId { get; set; }
        public int? RestaurantId { get; set; }
        public int Key1 { get; set; }
        public bool? Active { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}
