using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class Discount
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
        public string VisitorName { get; set; }
        public string DiscountType { get; set; }
    }
}
