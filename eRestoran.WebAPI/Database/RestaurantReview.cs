using System;
using System.Collections.Generic;

namespace eRestoran.WebAPI.Database
{
    public partial class RestaurantReview
    {
        public int RestaurantReviewId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public int? Grade { get; set; }

        public virtual User User { get; set; }
    }
}
