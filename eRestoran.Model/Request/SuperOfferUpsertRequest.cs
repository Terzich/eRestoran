using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class SuperOfferUpsertRequest
    {
        [Required]

        public string Description { get; set; }
        [Required]

        public DateTime OfferStart { get; set; }
        [Required]

        public DateTime OfferEnd { get; set; }
        public int? ItemTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? RestaurantMenuItemId { get; set; }
        public decimal? DiscountValue { get; set; }
        [Required]

        public bool? Active { get; set; }
        public int? DiscountType { get; set; }
    }
}
