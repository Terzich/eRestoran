using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class SuperOffer
    {
        public int SuperOfferId { get; set; }
        public string Description { get; set; }
        public DateTime OfferStart { get; set; }
        public DateTime OfferEnd { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? RestaurantMenuItemId { get; set; }
        public decimal? DiscountValue { get; set; }
    }
}
