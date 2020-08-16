using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class Discount
    {
        public int DiscountId { get; set; }
        public int UserId { get; set; }
        public int DiscountTypeId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? RestaurantMenuItemId { get; set; }
        public DateTime? DiscountDate { get; set; }
        public bool? Active { get; set; }
        public decimal? DiscountValue { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual ItemCategory ItemCategory { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual RestaurantMenuItem RestaurantMenuItem { get; set; }
        public virtual User User { get; set; }
    }
}
