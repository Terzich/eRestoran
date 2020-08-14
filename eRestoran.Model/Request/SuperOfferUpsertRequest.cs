using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model.Request
{
    public class SuperOfferUpsertRequest
    {
        public string Description { get; set; }
        public DateTime OfferStart { get; set; }
        public DateTime OfferEnd { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? RestaurantMenuItemId { get; set; }
        public decimal? DiscountValue { get; set; }
    }
}
