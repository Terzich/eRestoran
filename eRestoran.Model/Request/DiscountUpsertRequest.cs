using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class DiscountUpsertRequest
    {
        public int UserId { get; set; }
        public int DiscountTypeId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? RestaurantMenuItemId { get; set; }
        public DateTime? DiscountDate { get; set; }
        public bool? Active { get; set; }
        public decimal? DiscountValue { get; set; }
    }
}
