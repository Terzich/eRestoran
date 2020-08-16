using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class RestaurantMenuItem
    {
        public int RestaurantMenuItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        public int? QuantityId { get; set; }
        public string QuantityName { get; set; }
        public byte[] Image { get; set; }
    }
}
