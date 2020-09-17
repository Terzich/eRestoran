using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Key
    {
        public int KeyId { get; set; }
        public int? RestaurantId { get; set; }
        public int Key1 { get; set; }
        public bool? Active { get; set; }
    }
}
