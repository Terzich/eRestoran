using System;
using System.Collections.Generic;
using System.Text;

namespace eRestoran.Model
{
    public class RestaurantReview
    {
        public int RestaurantReviewId { get; set; }
        public int UserId { get; set; }
        public string VisitorName { get; set; }

        public string Description { get; set; }
        public int? Grade { get; set; }
    }
}
