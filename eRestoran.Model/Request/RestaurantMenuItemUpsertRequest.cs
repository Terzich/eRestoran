using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class RestaurantMenuItemUpsertRequest
    {
        [Required]

        public string ItemName { get; set; }
        [Required]

        public decimal Price { get; set; }
        [Required]

        

        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        [Required]

        public int? QuantityId { get; set; }
        public string QuantityName { get; set; }
        

        public byte[] Image { get; set; }
    }
}
