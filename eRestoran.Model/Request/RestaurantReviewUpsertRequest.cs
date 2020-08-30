using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class RestaurantReviewUpsertRequest
    {
        [Required]

        public int UserId { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]

        public int? Grade { get; set; }
    }
}
