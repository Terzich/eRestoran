using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class DiscountUpsertRequest
    {
        [Required]

        public int UserId { get; set; }
        [Required]

        public int DiscountTypeId { get; set; }
        

        public int? ItemTypeId { get; set; }
        

        public int? ItemCategoryId { get; set; }
        

        public int? RestaurantMenuItemId { get; set; }
        [Required]

        public DateTime? DiscountDate { get; set; }
        [Required]

        public bool? Active { get; set; }
        [Required]

        public decimal? DiscountValue { get; set; }
    }
}
