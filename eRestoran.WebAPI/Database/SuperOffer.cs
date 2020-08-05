using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class SuperOffer
    {
        public int SuperOfferId { get; set; }
        public string Description { get; set; }
        public DateTime OfferStart { get; set; }
        public DateTime OfferEnd { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? RestaurantMenuItemId { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual RestaurantMenuItem RestaurantMenuItem { get; set; }
    }
}
